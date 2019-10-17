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
                                                                                                                                            // Generate_ElementNode_FindChild.cs:126
namespace FhirKhit.Tools.R4
{                                                                                                                                           // Generate_ElementNode_FindChild.cs:134
    public partial class ElementDefinitionNode                                                                                              // Generate_ElementNode_FindChild.cs:135
    {                                                                                                                                       // Generate_ElementNode_FindChild.cs:136
        /// <summary>
        /// Create ElementDefinitionNode for child of common/primitive Fhir data type elements
        /// </summary>
        public ElementDefinitionNode FindCommonChild(String parentPath, String childName)                                                   // Generate_ElementNode_FindChild.cs:150
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:151
            switch (this.FhirItemType.FriendlyName())                                                                                       // Generate_ElementNode_FindChild.cs:152
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:153
                case "Ratio": return FindChildRatio(parentPath, childName);                                                                 // Generate_ElementNode_FindChild.cs:38
                case "Period": return FindChildPeriod(parentPath, childName);                                                               // Generate_ElementNode_FindChild.cs:38
                case "Range": return FindChildRange(parentPath, childName);                                                                 // Generate_ElementNode_FindChild.cs:38
                case "Attachment": return FindChildAttachment(parentPath, childName);                                                       // Generate_ElementNode_FindChild.cs:38
                case "Identifier": return FindChildIdentifier(parentPath, childName);                                                       // Generate_ElementNode_FindChild.cs:38
                case "Annotation": return FindChildAnnotation(parentPath, childName);                                                       // Generate_ElementNode_FindChild.cs:38
                case "HumanName": return FindChildHumanName(parentPath, childName);                                                         // Generate_ElementNode_FindChild.cs:38
                case "CodeableConcept": return FindChildCodeableConcept(parentPath, childName);                                             // Generate_ElementNode_FindChild.cs:38
                case "ContactPoint": return FindChildContactPoint(parentPath, childName);                                                   // Generate_ElementNode_FindChild.cs:38
                case "Coding": return FindChildCoding(parentPath, childName);                                                               // Generate_ElementNode_FindChild.cs:38
                case "Money": return FindChildMoney(parentPath, childName);                                                                 // Generate_ElementNode_FindChild.cs:38
                case "Address": return FindChildAddress(parentPath, childName);                                                             // Generate_ElementNode_FindChild.cs:38
                case "Timing": return FindChildTiming(parentPath, childName);                                                               // Generate_ElementNode_FindChild.cs:38
                case "Quantity": return FindChildQuantity(parentPath, childName);                                                           // Generate_ElementNode_FindChild.cs:38
                case "SampledData": return FindChildSampledData(parentPath, childName);                                                     // Generate_ElementNode_FindChild.cs:38
                case "Signature": return FindChildSignature(parentPath, childName);                                                         // Generate_ElementNode_FindChild.cs:38
                case "Age": return FindChildAge(parentPath, childName);                                                                     // Generate_ElementNode_FindChild.cs:38
                case "Distance": return FindChildDistance(parentPath, childName);                                                           // Generate_ElementNode_FindChild.cs:38
                case "Duration": return FindChildDuration(parentPath, childName);                                                           // Generate_ElementNode_FindChild.cs:38
                case "Count": return FindChildCount(parentPath, childName);                                                                 // Generate_ElementNode_FindChild.cs:38
                case "MoneyQuantity": return FindChildMoneyQuantity(parentPath, childName);                                                 // Generate_ElementNode_FindChild.cs:38
                case "SimpleQuantity": return FindChildSimpleQuantity(parentPath, childName);                                               // Generate_ElementNode_FindChild.cs:38
                case "Extension": return FindChildExtension(parentPath, childName);                                                         // Generate_ElementNode_FindChild.cs:38
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:184
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:185
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:186
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildRatio(String parentPath, String childName)                                                           // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "numerator":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.numerator",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Ratio.numerator common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Quantity), nameof(Ratio.Numerator));                                 // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "denominator":                                                                                                         // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.denominator",                                                                                 // Generate_ElementNode_FindChild.cs:82
                        Short = "Ratio.denominator common attribute",                                                                       // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Quantity), nameof(Ratio.Denominator));                               // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Ratio.id common attribute",                                                                                // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Ratio.ElementId));                                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Ratio.extension common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Ratio.Extension));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildPeriod(String parentPath, String childName)                                                          // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "start":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.start",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Period.start common attribute",                                                                            // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDateTime), nameof(Period.StartElement));                         // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "end":                                                                                                                 // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.end",                                                                                         // Generate_ElementNode_FindChild.cs:82
                        Short = "Period.end common attribute",                                                                              // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDateTime), nameof(Period.EndElement));                           // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Period.id common attribute",                                                                               // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Period.ElementId));                                  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Period.extension common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Period.Extension));                         // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildRange(String parentPath, String childName)                                                           // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "low":                                                                                                                 // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.low",                                                                                         // Generate_ElementNode_FindChild.cs:82
                        Short = "Range.low common attribute",                                                                               // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(SimpleQuantity), nameof(Range.Low));                                 // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "high":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.high",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Range.high common attribute",                                                                              // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(SimpleQuantity), nameof(Range.High));                                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Range.id common attribute",                                                                                // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Range.ElementId));                                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Range.extension common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Range.Extension));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildAttachment(String parentPath, String childName)                                                      // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "contentType":                                                                                                         // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.contentType",                                                                                 // Generate_ElementNode_FindChild.cs:82
                        Short = "Attachment.contentType common attribute",                                                                  // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(Attachment.ContentTypeElement));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "language":                                                                                                            // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.language",                                                                                    // Generate_ElementNode_FindChild.cs:82
                        Short = "Attachment.language common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(Attachment.LanguageElement));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "data":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.data",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Attachment.data common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Base64Binary), nameof(Attachment.DataElement));                      // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "url":                                                                                                                 // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.url",                                                                                         // Generate_ElementNode_FindChild.cs:82
                        Short = "Attachment.url common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirUrl), nameof(Attachment.UrlElement));                            // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "size":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.size",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Attachment.size common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(UnsignedInt), nameof(Attachment.SizeElement));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "hash":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.hash",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Attachment.hash common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Base64Binary), nameof(Attachment.HashElement));                      // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "title":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.title",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Attachment.title common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Attachment.TitleElement));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "creation":                                                                                                            // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.creation",                                                                                    // Generate_ElementNode_FindChild.cs:82
                        Short = "Attachment.creation common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDateTime), nameof(Attachment.CreationElement));                  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Attachment.id common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Attachment.ElementId));                              // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Attachment.extension common attribute",                                                                    // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Attachment.Extension));                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildIdentifier(String parentPath, String childName)                                                      // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "use":                                                                                                                 // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.use",                                                                                         // Generate_ElementNode_FindChild.cs:82
                        Short = "Identifier.use common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Identifier.IdentifierUse>), nameof(Identifier.UseElement));     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "type":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.type",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Identifier.type common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(CodeableConcept), nameof(Identifier.Type));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "system":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.system",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Identifier.system common attribute",                                                                       // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirUri), nameof(Identifier.SystemElement));                         // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Identifier.value common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Identifier.ValueElement));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "period":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.period",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Identifier.period common attribute",                                                                       // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Period), nameof(Identifier.Period));                                 // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "assigner":                                                                                                            // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.assigner",                                                                                    // Generate_ElementNode_FindChild.cs:82
                        Short = "Identifier.assigner common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(ResourceReference), nameof(Identifier.Assigner));                    // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Identifier.id common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Identifier.ElementId));                              // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Identifier.extension common attribute",                                                                    // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Identifier.Extension));                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildAnnotation(String parentPath, String childName)                                                      // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "author":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.author",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Annotation.author common attribute",                                                                       // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Element), nameof(Annotation.Author));                                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "time":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.time",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Annotation.time common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDateTime), nameof(Annotation.TimeElement));                      // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "text":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.text",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Annotation.text common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Markdown), nameof(Annotation.Text));                                 // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Annotation.id common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Annotation.ElementId));                              // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Annotation.extension common attribute",                                                                    // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Annotation.Extension));                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildHumanName(String parentPath, String childName)                                                       // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "use":                                                                                                                 // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.use",                                                                                         // Generate_ElementNode_FindChild.cs:82
                        Short = "HumanName.use common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<HumanName.NameUse>), nameof(HumanName.UseElement));             // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "text":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.text",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "HumanName.text common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(HumanName.TextElement));                         // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "family":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.family",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "HumanName.family common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(HumanName.FamilyElement));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "given":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.given",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "HumanName.given common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<FhirString>), nameof(HumanName.GivenElement));                  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "prefix":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.prefix",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "HumanName.prefix common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<FhirString>), nameof(HumanName.PrefixElement));                 // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "suffix":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.suffix",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "HumanName.suffix common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<FhirString>), nameof(HumanName.SuffixElement));                 // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "period":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.period",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "HumanName.period common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Period), nameof(HumanName.Period));                                  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "HumanName.id common attribute",                                                                            // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(HumanName.ElementId));                               // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "HumanName.extension common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(HumanName.Extension));                      // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildCodeableConcept(String parentPath, String childName)                                                 // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "coding":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.coding",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "CodeableConcept.coding common attribute",                                                                  // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Coding>), nameof(CodeableConcept.Coding));                      // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "text":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.text",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "CodeableConcept.text common attribute",                                                                    // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(CodeableConcept.TextElement));                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "CodeableConcept.id common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(CodeableConcept.ElementId));                         // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "CodeableConcept.extension common attribute",                                                               // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(CodeableConcept.Extension));                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildContactPoint(String parentPath, String childName)                                                    // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "system":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.system",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "ContactPoint.system common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<ContactPoint.ContactPointSystem>), nameof(ContactPoint.SystemElement));// Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "ContactPoint.value common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(ContactPoint.ValueElement));                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "use":                                                                                                                 // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.use",                                                                                         // Generate_ElementNode_FindChild.cs:82
                        Short = "ContactPoint.use common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<ContactPoint.ContactPointUse>), nameof(ContactPoint.UseElement));// Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "rank":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.rank",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "ContactPoint.rank common attribute",                                                                       // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(PositiveInt), nameof(ContactPoint.RankElement));                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "period":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.period",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "ContactPoint.period common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Period), nameof(ContactPoint.Period));                               // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "ContactPoint.id common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(ContactPoint.ElementId));                            // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "ContactPoint.extension common attribute",                                                                  // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(ContactPoint.Extension));                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildCoding(String parentPath, String childName)                                                          // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "system":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.system",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Coding.system common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirUri), nameof(Coding.SystemElement));                             // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "version":                                                                                                             // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.version",                                                                                     // Generate_ElementNode_FindChild.cs:82
                        Short = "Coding.version common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Coding.VersionElement));                         // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "code":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.code",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Coding.code common attribute",                                                                             // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(Coding.CodeElement));                                  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "display":                                                                                                             // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.display",                                                                                     // Generate_ElementNode_FindChild.cs:82
                        Short = "Coding.display common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Coding.DisplayElement));                         // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "userSelected":                                                                                                        // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.userSelected",                                                                                // Generate_ElementNode_FindChild.cs:82
                        Short = "Coding.userSelected common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirBoolean), nameof(Coding.UserSelectedElement));                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Coding.id common attribute",                                                                               // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Coding.ElementId));                                  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Coding.extension common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Coding.Extension));                         // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildMoney(String parentPath, String childName)                                                           // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Money.value common attribute",                                                                             // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(Money.ValueElement));                           // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "currency":                                                                                                            // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.currency",                                                                                    // Generate_ElementNode_FindChild.cs:82
                        Short = "Money.currency common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Money.Currencies>), nameof(Money.CurrencyElement));             // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Money.id common attribute",                                                                                // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Money.ElementId));                                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Money.extension common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Money.Extension));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildAddress(String parentPath, String childName)                                                         // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "use":                                                                                                                 // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.use",                                                                                         // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.use common attribute",                                                                             // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Address.AddressUse>), nameof(Address.UseElement));              // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "type":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.type",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.type common attribute",                                                                            // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Address.AddressType>), nameof(Address.TypeElement));            // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "text":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.text",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.text common attribute",                                                                            // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Address.TextElement));                           // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "line":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.line",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.line common attribute",                                                                            // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<FhirString>), nameof(Address.LineElement));                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "city":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.city",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.city common attribute",                                                                            // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Address.CityElement));                           // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "district":                                                                                                            // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.district",                                                                                    // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.district common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Address.DistrictElement));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "state":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.state",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.state common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Address.StateElement));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "postalCode":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.postalCode",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.postalCode common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Address.PostalCodeElement));                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "country":                                                                                                             // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.country",                                                                                     // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.country common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Address.CountryElement));                        // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "period":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.period",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.period common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Period), nameof(Address.Period));                                    // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.id common attribute",                                                                              // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Address.ElementId));                                 // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Address.extension common attribute",                                                                       // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Address.Extension));                        // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildTiming(String parentPath, String childName)                                                          // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "event":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.event",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Timing.event common attribute",                                                                            // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<FhirDateTime>), nameof(Timing.EventElement));                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "repeat":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.repeat",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Timing.repeat common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Timing.RepeatComponent), nameof(Timing.Repeat));                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "code":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.code",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Timing.code common attribute",                                                                             // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(CodeableConcept), nameof(Timing.Code));                              // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "modifierExtension":                                                                                                   // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.modifierExtension",                                                                           // Generate_ElementNode_FindChild.cs:82
                        Short = "Timing.modifierExtension common attribute",                                                                // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Timing.ModifierExtension));                 // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Timing.id common attribute",                                                                               // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Timing.ElementId));                                  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Timing.extension common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Timing.Extension));                         // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildQuantity(String parentPath, String childName)                                                        // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Quantity.value common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(Quantity.ValueElement));                        // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "comparator":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.comparator",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "Quantity.comparator common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Quantity.ComparatorElement));// Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "unit":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.unit",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Quantity.unit common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Quantity.UnitElement));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "system":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.system",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Quantity.system common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirUri), nameof(Quantity.SystemElement));                           // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "code":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.code",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Quantity.code common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(Quantity.CodeElement));                                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Quantity.id common attribute",                                                                             // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Quantity.ElementId));                                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Quantity.extension common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Quantity.Extension));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildSampledData(String parentPath, String childName)                                                     // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "origin":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.origin",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "SampledData.origin common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(SimpleQuantity), nameof(SampledData.Origin));                        // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "period":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.period",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "SampledData.period common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(SampledData.PeriodElement));                    // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "factor":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.factor",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "SampledData.factor common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(SampledData.FactorElement));                    // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "lowerLimit":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.lowerLimit",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "SampledData.lowerLimit common attribute",                                                                  // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(SampledData.LowerLimitElement));                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "upperLimit":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.upperLimit",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "SampledData.upperLimit common attribute",                                                                  // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(SampledData.UpperLimitElement));                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "dimensions":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.dimensions",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "SampledData.dimensions common attribute",                                                                  // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(PositiveInt), nameof(SampledData.DimensionsElement));                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "data":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.data",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "SampledData.data common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(SampledData.DataElement));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "SampledData.id common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(SampledData.ElementId));                             // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "SampledData.extension common attribute",                                                                   // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(SampledData.Extension));                    // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildSignature(String parentPath, String childName)                                                       // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "type":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.type",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Signature.type common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Coding>), nameof(Signature.Type));                              // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "when":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.when",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Signature.when common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Instant), nameof(Signature.WhenElement));                            // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "who":                                                                                                                 // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.who",                                                                                         // Generate_ElementNode_FindChild.cs:82
                        Short = "Signature.who common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(ResourceReference), nameof(Signature.Who));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "onBehalfOf":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.onBehalfOf",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "Signature.onBehalfOf common attribute",                                                                    // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(ResourceReference), nameof(Signature.OnBehalfOf));                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "targetFormat":                                                                                                        // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.targetFormat",                                                                                // Generate_ElementNode_FindChild.cs:82
                        Short = "Signature.targetFormat common attribute",                                                                  // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(Signature.TargetFormatElement));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "sigFormat":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.sigFormat",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Signature.sigFormat common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(Signature.SigFormatElement));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "data":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.data",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Signature.data common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Base64Binary), nameof(Signature.DataElement));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Signature.id common attribute",                                                                            // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Signature.ElementId));                               // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Signature.extension common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Signature.Extension));                      // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildAge(String parentPath, String childName)                                                             // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Age.value common attribute",                                                                               // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(Age.ValueElement));                             // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "comparator":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.comparator",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "Age.comparator common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Age.ComparatorElement));  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "unit":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.unit",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Age.unit common attribute",                                                                                // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Age.UnitElement));                               // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "system":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.system",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Age.system common attribute",                                                                              // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirUri), nameof(Age.SystemElement));                                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "code":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.code",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Age.code common attribute",                                                                                // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(Age.CodeElement));                                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Age.id common attribute",                                                                                  // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Age.ElementId));                                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Age.extension common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Age.Extension));                            // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildDistance(String parentPath, String childName)                                                        // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Distance.value common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(Distance.ValueElement));                        // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "comparator":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.comparator",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "Distance.comparator common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Distance.ComparatorElement));// Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "unit":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.unit",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Distance.unit common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Distance.UnitElement));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "system":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.system",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Distance.system common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirUri), nameof(Distance.SystemElement));                           // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "code":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.code",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Distance.code common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(Distance.CodeElement));                                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Distance.id common attribute",                                                                             // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Distance.ElementId));                                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Distance.extension common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Distance.Extension));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildDuration(String parentPath, String childName)                                                        // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Duration.value common attribute",                                                                          // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(Duration.ValueElement));                        // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "comparator":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.comparator",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "Duration.comparator common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Duration.ComparatorElement));// Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "unit":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.unit",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Duration.unit common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Duration.UnitElement));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "system":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.system",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Duration.system common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirUri), nameof(Duration.SystemElement));                           // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "code":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.code",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Duration.code common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(Duration.CodeElement));                                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Duration.id common attribute",                                                                             // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Duration.ElementId));                                // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Duration.extension common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Duration.Extension));                       // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildCount(String parentPath, String childName)                                                           // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Count.value common attribute",                                                                             // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(Count.ValueElement));                           // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "comparator":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.comparator",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "Count.comparator common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Count.ComparatorElement));// Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "unit":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.unit",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Count.unit common attribute",                                                                              // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(Count.UnitElement));                             // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "system":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.system",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "Count.system common attribute",                                                                            // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirUri), nameof(Count.SystemElement));                              // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "code":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.code",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "Count.code common attribute",                                                                              // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(Count.CodeElement));                                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Count.id common attribute",                                                                                // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Count.ElementId));                                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Count.extension common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Count.Extension));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildMoneyQuantity(String parentPath, String childName)                                                   // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "MoneyQuantity.value common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(MoneyQuantity.ValueElement));                   // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "comparator":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.comparator",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "MoneyQuantity.comparator common attribute",                                                                // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(MoneyQuantity.ComparatorElement));// Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "unit":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.unit",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "MoneyQuantity.unit common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(MoneyQuantity.UnitElement));                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "system":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.system",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "MoneyQuantity.system common attribute",                                                                    // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirUri), nameof(MoneyQuantity.SystemElement));                      // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "code":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.code",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "MoneyQuantity.code common attribute",                                                                      // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(MoneyQuantity.CodeElement));                           // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "MoneyQuantity.id common attribute",                                                                        // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(MoneyQuantity.ElementId));                           // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "MoneyQuantity.extension common attribute",                                                                 // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(MoneyQuantity.Extension));                  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildSimpleQuantity(String parentPath, String childName)                                                  // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "SimpleQuantity.value common attribute",                                                                    // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirDecimal), nameof(SimpleQuantity.ValueElement));                  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "comparator":                                                                                                          // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.comparator",                                                                                  // Generate_ElementNode_FindChild.cs:82
                        Short = "SimpleQuantity.comparator common attribute",                                                               // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(SimpleQuantity.ComparatorElement));// Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "unit":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.unit",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "SimpleQuantity.unit common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirString), nameof(SimpleQuantity.UnitElement));                    // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "system":                                                                                                              // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.system",                                                                                      // Generate_ElementNode_FindChild.cs:82
                        Short = "SimpleQuantity.system common attribute",                                                                   // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(FhirUri), nameof(SimpleQuantity.SystemElement));                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "code":                                                                                                                // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.code",                                                                                        // Generate_ElementNode_FindChild.cs:82
                        Short = "SimpleQuantity.code common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Code), nameof(SimpleQuantity.CodeElement));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "SimpleQuantity.id common attribute",                                                                       // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(SimpleQuantity.ElementId));                          // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "SimpleQuantity.extension common attribute",                                                                // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(SimpleQuantity.Extension));                 // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
                                                                                                                                            // Generate_ElementNode_FindChild.cs:42
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementDefinitionNode FindChildExtension(String parentPath, String childName)                                                       // Generate_ElementNode_FindChild.cs:46
        {                                                                                                                                   // Generate_ElementNode_FindChild.cs:47
            ElementDefinitionNode retVal;                                                                                                   // Generate_ElementNode_FindChild.cs:48
            switch (childName)                                                                                                              // Generate_ElementNode_FindChild.cs:49
            {                                                                                                                               // Generate_ElementNode_FindChild.cs:50
                case "url":                                                                                                                 // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.url",                                                                                         // Generate_ElementNode_FindChild.cs:82
                        Short = "Extension.url common attribute",                                                                           // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Extension.Url));                                     // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "value":                                                                                                               // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.value",                                                                                       // Generate_ElementNode_FindChild.cs:82
                        Short = "Extension.value common attribute",                                                                         // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(Element), nameof(Extension.Value));                                  // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "id":                                                                                                                  // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.id",                                                                                          // Generate_ElementNode_FindChild.cs:82
                        Short = "Extension.id common attribute",                                                                            // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(string), nameof(Extension.ElementId));                               // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                case "extension":                                                                                                           // Generate_ElementNode_FindChild.cs:78
                {                                                                                                                           // Generate_ElementNode_FindChild.cs:79
                    ElementDefinition e = new ElementDefinition                                                                             // Generate_ElementNode_FindChild.cs:80
                    {                                                                                                                       // Generate_ElementNode_FindChild.cs:81
                        Path = $"{parentPath}.extension",                                                                                   // Generate_ElementNode_FindChild.cs:82
                        Short = "Extension.extension common attribute",                                                                     // Generate_ElementNode_FindChild.cs:83
                        Min = 1,                                                                                                            // Generate_ElementNode_FindChild.cs:84
                        Max = "1"                                                                                                           // Generate_ElementNode_FindChild.cs:85
                    };                                                                                                                      // Generate_ElementNode_FindChild.cs:86
                    retVal = new ElementDefinitionNode(this, e, typeof(List<Extension>), nameof(Extension.Extension));                      // Generate_ElementNode_FindChild.cs:87
                    retVal.AutoGeneratedFlag = true;                                                                                        // Generate_ElementNode_FindChild.cs:88
                    break;                                                                                                                  // Generate_ElementNode_FindChild.cs:89
                };                                                                                                                          // Generate_ElementNode_FindChild.cs:90
                default: return null;                                                                                                       // Generate_ElementNode_FindChild.cs:96
            }                                                                                                                               // Generate_ElementNode_FindChild.cs:97
            this.childNodeDictionary.Add(childName, retVal);                                                                                // Generate_ElementNode_FindChild.cs:98
            return retVal;                                                                                                                  // Generate_ElementNode_FindChild.cs:99
        }                                                                                                                                   // Generate_ElementNode_FindChild.cs:100
    }                                                                                                                                       // Generate_ElementNode_FindChild.cs:142
}                                                                                                                                           // Generate_ElementNode_FindChild.cs:143
