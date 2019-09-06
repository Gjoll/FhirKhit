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
                                                                                                                                            // CodeGeneration.cs:338
namespace FhirKhit.SliceGen.R4
{                                                                                                                                           // CodeGeneration.cs:340
    public partial class ElementNode                                                                                                        // CodeGeneration.cs:341
    {                                                                                                                                       // CodeGeneration.cs:342
        /// <summary>
        /// Create ElementNode for child of common/primitive Fhir data type elements
        /// </summary>
        public ElementNode FindCommonChild(String childName)                                                                                // CodeGeneration.cs:354
        {                                                                                                                                   // CodeGeneration.cs:355
            switch (this.FhirItemType.FriendlyName())                                                                                       // CodeGeneration.cs:356
            {                                                                                                                               // CodeGeneration.cs:357
                case "Ratio": return FindChildRatio(childName);                                                                             // CodeGeneration.cs:280
                case "Period": return FindChildPeriod(childName);                                                                           // CodeGeneration.cs:280
                case "Range": return FindChildRange(childName);                                                                             // CodeGeneration.cs:280
                case "Attachment": return FindChildAttachment(childName);                                                                   // CodeGeneration.cs:280
                case "Identifier": return FindChildIdentifier(childName);                                                                   // CodeGeneration.cs:280
                case "Annotation": return FindChildAnnotation(childName);                                                                   // CodeGeneration.cs:280
                case "HumanName": return FindChildHumanName(childName);                                                                     // CodeGeneration.cs:280
                case "CodeableConcept": return FindChildCodeableConcept(childName);                                                         // CodeGeneration.cs:280
                case "ContactPoint": return FindChildContactPoint(childName);                                                               // CodeGeneration.cs:280
                case "Coding": return FindChildCoding(childName);                                                                           // CodeGeneration.cs:280
                case "Money": return FindChildMoney(childName);                                                                             // CodeGeneration.cs:280
                case "Address": return FindChildAddress(childName);                                                                         // CodeGeneration.cs:280
                case "Timing": return FindChildTiming(childName);                                                                           // CodeGeneration.cs:280
                case "Quantity": return FindChildQuantity(childName);                                                                       // CodeGeneration.cs:280
                case "SampledData": return FindChildSampledData(childName);                                                                 // CodeGeneration.cs:280
                case "Signature": return FindChildSignature(childName);                                                                     // CodeGeneration.cs:280
                case "Age": return FindChildAge(childName);                                                                                 // CodeGeneration.cs:280
                case "Distance": return FindChildDistance(childName);                                                                       // CodeGeneration.cs:280
                case "Duration": return FindChildDuration(childName);                                                                       // CodeGeneration.cs:280
                case "Count": return FindChildCount(childName);                                                                             // CodeGeneration.cs:280
                case "MoneyQuantity": return FindChildMoneyQuantity(childName);                                                             // CodeGeneration.cs:280
                case "SimpleQuantity": return FindChildSimpleQuantity(childName);                                                           // CodeGeneration.cs:280
                case "Extension": return FindChildExtension(childName);                                                                     // CodeGeneration.cs:280
                default: return null;                                                                                                       // CodeGeneration.cs:387
            }                                                                                                                               // CodeGeneration.cs:388
        }                                                                                                                                   // CodeGeneration.cs:389
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildRatio(String childName)                                                                                        // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "numerator":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode numeratorVar = new ElementNode(this, null, typeof(Quantity), nameof(Ratio.Numerator));                      // CodeGeneration.cs:301
                    this.children.Add("numerator", numeratorVar);                                                                           // CodeGeneration.cs:302
                    return numeratorVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "denominator":                                                                                                         // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode denominatorVar = new ElementNode(this, null, typeof(Quantity), nameof(Ratio.Denominator));                  // CodeGeneration.cs:301
                    this.children.Add("denominator", denominatorVar);                                                                       // CodeGeneration.cs:302
                    return denominatorVar;                                                                                                  // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Ratio.ElementId));                               // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Ratio.Extension));               // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildPeriod(String childName)                                                                                       // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "start":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode startVar = new ElementNode(this, null, typeof(FhirDateTime), nameof(Period.StartElement));                  // CodeGeneration.cs:301
                    this.children.Add("start", startVar);                                                                                   // CodeGeneration.cs:302
                    return startVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "end":                                                                                                                 // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode endVar = new ElementNode(this, null, typeof(FhirDateTime), nameof(Period.EndElement));                      // CodeGeneration.cs:301
                    this.children.Add("end", endVar);                                                                                       // CodeGeneration.cs:302
                    return endVar;                                                                                                          // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Period.ElementId));                              // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Period.Extension));              // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildRange(String childName)                                                                                        // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "low":                                                                                                                 // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode lowVar = new ElementNode(this, null, typeof(SimpleQuantity), nameof(Range.Low));                            // CodeGeneration.cs:301
                    this.children.Add("low", lowVar);                                                                                       // CodeGeneration.cs:302
                    return lowVar;                                                                                                          // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "high":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode highVar = new ElementNode(this, null, typeof(SimpleQuantity), nameof(Range.High));                          // CodeGeneration.cs:301
                    this.children.Add("high", highVar);                                                                                     // CodeGeneration.cs:302
                    return highVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Range.ElementId));                               // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Range.Extension));               // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildAttachment(String childName)                                                                                   // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "contentType":                                                                                                         // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode contentTypeVar = new ElementNode(this, null, typeof(Code), nameof(Attachment.ContentTypeElement));          // CodeGeneration.cs:301
                    this.children.Add("contentType", contentTypeVar);                                                                       // CodeGeneration.cs:302
                    return contentTypeVar;                                                                                                  // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "language":                                                                                                            // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode languageVar = new ElementNode(this, null, typeof(Code), nameof(Attachment.LanguageElement));                // CodeGeneration.cs:301
                    this.children.Add("language", languageVar);                                                                             // CodeGeneration.cs:302
                    return languageVar;                                                                                                     // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "data":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode dataVar = new ElementNode(this, null, typeof(Base64Binary), nameof(Attachment.DataElement));                // CodeGeneration.cs:301
                    this.children.Add("data", dataVar);                                                                                     // CodeGeneration.cs:302
                    return dataVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "url":                                                                                                                 // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode urlVar = new ElementNode(this, null, typeof(FhirUrl), nameof(Attachment.UrlElement));                       // CodeGeneration.cs:301
                    this.children.Add("url", urlVar);                                                                                       // CodeGeneration.cs:302
                    return urlVar;                                                                                                          // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "size":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode sizeVar = new ElementNode(this, null, typeof(UnsignedInt), nameof(Attachment.SizeElement));                 // CodeGeneration.cs:301
                    this.children.Add("size", sizeVar);                                                                                     // CodeGeneration.cs:302
                    return sizeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "hash":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode hashVar = new ElementNode(this, null, typeof(Base64Binary), nameof(Attachment.HashElement));                // CodeGeneration.cs:301
                    this.children.Add("hash", hashVar);                                                                                     // CodeGeneration.cs:302
                    return hashVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "title":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode titleVar = new ElementNode(this, null, typeof(FhirString), nameof(Attachment.TitleElement));                // CodeGeneration.cs:301
                    this.children.Add("title", titleVar);                                                                                   // CodeGeneration.cs:302
                    return titleVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "creation":                                                                                                            // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode creationVar = new ElementNode(this, null, typeof(FhirDateTime), nameof(Attachment.CreationElement));        // CodeGeneration.cs:301
                    this.children.Add("creation", creationVar);                                                                             // CodeGeneration.cs:302
                    return creationVar;                                                                                                     // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Attachment.ElementId));                          // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Attachment.Extension));          // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildIdentifier(String childName)                                                                                   // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "use":                                                                                                                 // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode useVar = new ElementNode(this, null, typeof(Code<Identifier.IdentifierUse>), nameof(Identifier.UseElement));// CodeGeneration.cs:301
                    this.children.Add("use", useVar);                                                                                       // CodeGeneration.cs:302
                    return useVar;                                                                                                          // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "type":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode typeVar = new ElementNode(this, null, typeof(CodeableConcept), nameof(Identifier.Type));                    // CodeGeneration.cs:301
                    this.children.Add("type", typeVar);                                                                                     // CodeGeneration.cs:302
                    return typeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "system":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), nameof(Identifier.SystemElement));                 // CodeGeneration.cs:301
                    this.children.Add("system", systemVar);                                                                                 // CodeGeneration.cs:302
                    return systemVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(FhirString), nameof(Identifier.ValueElement));                // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "period":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode periodVar = new ElementNode(this, null, typeof(Period), nameof(Identifier.Period));                         // CodeGeneration.cs:301
                    this.children.Add("period", periodVar);                                                                                 // CodeGeneration.cs:302
                    return periodVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "assigner":                                                                                                            // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode assignerVar = new ElementNode(this, null, typeof(ResourceReference), nameof(Identifier.Assigner));          // CodeGeneration.cs:301
                    this.children.Add("assigner", assignerVar);                                                                             // CodeGeneration.cs:302
                    return assignerVar;                                                                                                     // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Identifier.ElementId));                          // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Identifier.Extension));          // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildAnnotation(String childName)                                                                                   // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "author":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode authorVar = new ElementNode(this, null, typeof(Element), nameof(Annotation.Author));                        // CodeGeneration.cs:301
                    this.children.Add("author", authorVar);                                                                                 // CodeGeneration.cs:302
                    return authorVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "time":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode timeVar = new ElementNode(this, null, typeof(FhirDateTime), nameof(Annotation.TimeElement));                // CodeGeneration.cs:301
                    this.children.Add("time", timeVar);                                                                                     // CodeGeneration.cs:302
                    return timeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "text":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode textVar = new ElementNode(this, null, typeof(Markdown), nameof(Annotation.Text));                           // CodeGeneration.cs:301
                    this.children.Add("text", textVar);                                                                                     // CodeGeneration.cs:302
                    return textVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Annotation.ElementId));                          // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Annotation.Extension));          // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildHumanName(String childName)                                                                                    // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "use":                                                                                                                 // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode useVar = new ElementNode(this, null, typeof(Code<HumanName.NameUse>), nameof(HumanName.UseElement));        // CodeGeneration.cs:301
                    this.children.Add("use", useVar);                                                                                       // CodeGeneration.cs:302
                    return useVar;                                                                                                          // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "text":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode textVar = new ElementNode(this, null, typeof(FhirString), nameof(HumanName.TextElement));                   // CodeGeneration.cs:301
                    this.children.Add("text", textVar);                                                                                     // CodeGeneration.cs:302
                    return textVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "family":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode familyVar = new ElementNode(this, null, typeof(FhirString), nameof(HumanName.FamilyElement));               // CodeGeneration.cs:301
                    this.children.Add("family", familyVar);                                                                                 // CodeGeneration.cs:302
                    return familyVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "given":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode givenVar = new ElementNode(this, null, typeof(List<FhirString>), nameof(HumanName.GivenElement));           // CodeGeneration.cs:301
                    this.children.Add("given", givenVar);                                                                                   // CodeGeneration.cs:302
                    return givenVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "prefix":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode prefixVar = new ElementNode(this, null, typeof(List<FhirString>), nameof(HumanName.PrefixElement));         // CodeGeneration.cs:301
                    this.children.Add("prefix", prefixVar);                                                                                 // CodeGeneration.cs:302
                    return prefixVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "suffix":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode suffixVar = new ElementNode(this, null, typeof(List<FhirString>), nameof(HumanName.SuffixElement));         // CodeGeneration.cs:301
                    this.children.Add("suffix", suffixVar);                                                                                 // CodeGeneration.cs:302
                    return suffixVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "period":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode periodVar = new ElementNode(this, null, typeof(Period), nameof(HumanName.Period));                          // CodeGeneration.cs:301
                    this.children.Add("period", periodVar);                                                                                 // CodeGeneration.cs:302
                    return periodVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(HumanName.ElementId));                           // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(HumanName.Extension));           // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildCodeableConcept(String childName)                                                                              // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "coding":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode codingVar = new ElementNode(this, null, typeof(List<Coding>), nameof(CodeableConcept.Coding));              // CodeGeneration.cs:301
                    this.children.Add("coding", codingVar);                                                                                 // CodeGeneration.cs:302
                    return codingVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "text":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode textVar = new ElementNode(this, null, typeof(FhirString), nameof(CodeableConcept.TextElement));             // CodeGeneration.cs:301
                    this.children.Add("text", textVar);                                                                                     // CodeGeneration.cs:302
                    return textVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(CodeableConcept.ElementId));                     // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(CodeableConcept.Extension));     // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildContactPoint(String childName)                                                                                 // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "system":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode systemVar = new ElementNode(this, null, typeof(Code<ContactPoint.ContactPointSystem>), nameof(ContactPoint.SystemElement));// CodeGeneration.cs:301
                    this.children.Add("system", systemVar);                                                                                 // CodeGeneration.cs:302
                    return systemVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(FhirString), nameof(ContactPoint.ValueElement));              // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "use":                                                                                                                 // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode useVar = new ElementNode(this, null, typeof(Code<ContactPoint.ContactPointUse>), nameof(ContactPoint.UseElement));// CodeGeneration.cs:301
                    this.children.Add("use", useVar);                                                                                       // CodeGeneration.cs:302
                    return useVar;                                                                                                          // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "rank":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode rankVar = new ElementNode(this, null, typeof(PositiveInt), nameof(ContactPoint.RankElement));               // CodeGeneration.cs:301
                    this.children.Add("rank", rankVar);                                                                                     // CodeGeneration.cs:302
                    return rankVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "period":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode periodVar = new ElementNode(this, null, typeof(Period), nameof(ContactPoint.Period));                       // CodeGeneration.cs:301
                    this.children.Add("period", periodVar);                                                                                 // CodeGeneration.cs:302
                    return periodVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(ContactPoint.ElementId));                        // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(ContactPoint.Extension));        // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildCoding(String childName)                                                                                       // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "system":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), nameof(Coding.SystemElement));                     // CodeGeneration.cs:301
                    this.children.Add("system", systemVar);                                                                                 // CodeGeneration.cs:302
                    return systemVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "version":                                                                                                             // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode versionVar = new ElementNode(this, null, typeof(FhirString), nameof(Coding.VersionElement));                // CodeGeneration.cs:301
                    this.children.Add("version", versionVar);                                                                               // CodeGeneration.cs:302
                    return versionVar;                                                                                                      // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "code":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode codeVar = new ElementNode(this, null, typeof(Code), nameof(Coding.CodeElement));                            // CodeGeneration.cs:301
                    this.children.Add("code", codeVar);                                                                                     // CodeGeneration.cs:302
                    return codeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "display":                                                                                                             // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode displayVar = new ElementNode(this, null, typeof(FhirString), nameof(Coding.DisplayElement));                // CodeGeneration.cs:301
                    this.children.Add("display", displayVar);                                                                               // CodeGeneration.cs:302
                    return displayVar;                                                                                                      // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "userSelected":                                                                                                        // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode userSelectedVar = new ElementNode(this, null, typeof(FhirBoolean), nameof(Coding.UserSelectedElement));     // CodeGeneration.cs:301
                    this.children.Add("userSelected", userSelectedVar);                                                                     // CodeGeneration.cs:302
                    return userSelectedVar;                                                                                                 // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Coding.ElementId));                              // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Coding.Extension));              // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildMoney(String childName)                                                                                        // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(Money.ValueElement));                    // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "currency":                                                                                                            // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode currencyVar = new ElementNode(this, null, typeof(Code<Money.Currencies>), nameof(Money.CurrencyElement));   // CodeGeneration.cs:301
                    this.children.Add("currency", currencyVar);                                                                             // CodeGeneration.cs:302
                    return currencyVar;                                                                                                     // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Money.ElementId));                               // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Money.Extension));               // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildAddress(String childName)                                                                                      // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "use":                                                                                                                 // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode useVar = new ElementNode(this, null, typeof(Code<Address.AddressUse>), nameof(Address.UseElement));         // CodeGeneration.cs:301
                    this.children.Add("use", useVar);                                                                                       // CodeGeneration.cs:302
                    return useVar;                                                                                                          // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "type":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode typeVar = new ElementNode(this, null, typeof(Code<Address.AddressType>), nameof(Address.TypeElement));      // CodeGeneration.cs:301
                    this.children.Add("type", typeVar);                                                                                     // CodeGeneration.cs:302
                    return typeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "text":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode textVar = new ElementNode(this, null, typeof(FhirString), nameof(Address.TextElement));                     // CodeGeneration.cs:301
                    this.children.Add("text", textVar);                                                                                     // CodeGeneration.cs:302
                    return textVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "line":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode lineVar = new ElementNode(this, null, typeof(List<FhirString>), nameof(Address.LineElement));               // CodeGeneration.cs:301
                    this.children.Add("line", lineVar);                                                                                     // CodeGeneration.cs:302
                    return lineVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "city":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode cityVar = new ElementNode(this, null, typeof(FhirString), nameof(Address.CityElement));                     // CodeGeneration.cs:301
                    this.children.Add("city", cityVar);                                                                                     // CodeGeneration.cs:302
                    return cityVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "district":                                                                                                            // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode districtVar = new ElementNode(this, null, typeof(FhirString), nameof(Address.DistrictElement));             // CodeGeneration.cs:301
                    this.children.Add("district", districtVar);                                                                             // CodeGeneration.cs:302
                    return districtVar;                                                                                                     // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "state":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode stateVar = new ElementNode(this, null, typeof(FhirString), nameof(Address.StateElement));                   // CodeGeneration.cs:301
                    this.children.Add("state", stateVar);                                                                                   // CodeGeneration.cs:302
                    return stateVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "postalCode":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode postalCodeVar = new ElementNode(this, null, typeof(FhirString), nameof(Address.PostalCodeElement));         // CodeGeneration.cs:301
                    this.children.Add("postalCode", postalCodeVar);                                                                         // CodeGeneration.cs:302
                    return postalCodeVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "country":                                                                                                             // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode countryVar = new ElementNode(this, null, typeof(FhirString), nameof(Address.CountryElement));               // CodeGeneration.cs:301
                    this.children.Add("country", countryVar);                                                                               // CodeGeneration.cs:302
                    return countryVar;                                                                                                      // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "period":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode periodVar = new ElementNode(this, null, typeof(Period), nameof(Address.Period));                            // CodeGeneration.cs:301
                    this.children.Add("period", periodVar);                                                                                 // CodeGeneration.cs:302
                    return periodVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Address.ElementId));                             // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Address.Extension));             // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildTiming(String childName)                                                                                       // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "event":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode eventVar = new ElementNode(this, null, typeof(List<FhirDateTime>), nameof(Timing.EventElement));            // CodeGeneration.cs:301
                    this.children.Add("event", eventVar);                                                                                   // CodeGeneration.cs:302
                    return eventVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "repeat":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode repeatVar = new ElementNode(this, null, typeof(Timing.RepeatComponent), nameof(Timing.Repeat));             // CodeGeneration.cs:301
                    this.children.Add("repeat", repeatVar);                                                                                 // CodeGeneration.cs:302
                    return repeatVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "code":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode codeVar = new ElementNode(this, null, typeof(CodeableConcept), nameof(Timing.Code));                        // CodeGeneration.cs:301
                    this.children.Add("code", codeVar);                                                                                     // CodeGeneration.cs:302
                    return codeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "modifierExtension":                                                                                                   // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode modifierExtensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Timing.ModifierExtension));// CodeGeneration.cs:301
                    this.children.Add("modifierExtension", modifierExtensionVar);                                                           // CodeGeneration.cs:302
                    return modifierExtensionVar;                                                                                            // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Timing.ElementId));                              // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Timing.Extension));              // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildQuantity(String childName)                                                                                     // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(Quantity.ValueElement));                 // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "comparator":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), nameof(Quantity.ComparatorElement));// CodeGeneration.cs:301
                    this.children.Add("comparator", comparatorVar);                                                                         // CodeGeneration.cs:302
                    return comparatorVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "unit":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), nameof(Quantity.UnitElement));                    // CodeGeneration.cs:301
                    this.children.Add("unit", unitVar);                                                                                     // CodeGeneration.cs:302
                    return unitVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "system":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), nameof(Quantity.SystemElement));                   // CodeGeneration.cs:301
                    this.children.Add("system", systemVar);                                                                                 // CodeGeneration.cs:302
                    return systemVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "code":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode codeVar = new ElementNode(this, null, typeof(Code), nameof(Quantity.CodeElement));                          // CodeGeneration.cs:301
                    this.children.Add("code", codeVar);                                                                                     // CodeGeneration.cs:302
                    return codeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Quantity.ElementId));                            // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Quantity.Extension));            // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildSampledData(String childName)                                                                                  // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "origin":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode originVar = new ElementNode(this, null, typeof(SimpleQuantity), nameof(SampledData.Origin));                // CodeGeneration.cs:301
                    this.children.Add("origin", originVar);                                                                                 // CodeGeneration.cs:302
                    return originVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "period":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode periodVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(SampledData.PeriodElement));            // CodeGeneration.cs:301
                    this.children.Add("period", periodVar);                                                                                 // CodeGeneration.cs:302
                    return periodVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "factor":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode factorVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(SampledData.FactorElement));            // CodeGeneration.cs:301
                    this.children.Add("factor", factorVar);                                                                                 // CodeGeneration.cs:302
                    return factorVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "lowerLimit":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode lowerLimitVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(SampledData.LowerLimitElement));    // CodeGeneration.cs:301
                    this.children.Add("lowerLimit", lowerLimitVar);                                                                         // CodeGeneration.cs:302
                    return lowerLimitVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "upperLimit":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode upperLimitVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(SampledData.UpperLimitElement));    // CodeGeneration.cs:301
                    this.children.Add("upperLimit", upperLimitVar);                                                                         // CodeGeneration.cs:302
                    return upperLimitVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "dimensions":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode dimensionsVar = new ElementNode(this, null, typeof(PositiveInt), nameof(SampledData.DimensionsElement));    // CodeGeneration.cs:301
                    this.children.Add("dimensions", dimensionsVar);                                                                         // CodeGeneration.cs:302
                    return dimensionsVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "data":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode dataVar = new ElementNode(this, null, typeof(FhirString), nameof(SampledData.DataElement));                 // CodeGeneration.cs:301
                    this.children.Add("data", dataVar);                                                                                     // CodeGeneration.cs:302
                    return dataVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(SampledData.ElementId));                         // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(SampledData.Extension));         // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildSignature(String childName)                                                                                    // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "type":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode typeVar = new ElementNode(this, null, typeof(List<Coding>), nameof(Signature.Type));                        // CodeGeneration.cs:301
                    this.children.Add("type", typeVar);                                                                                     // CodeGeneration.cs:302
                    return typeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "when":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode whenVar = new ElementNode(this, null, typeof(Instant), nameof(Signature.WhenElement));                      // CodeGeneration.cs:301
                    this.children.Add("when", whenVar);                                                                                     // CodeGeneration.cs:302
                    return whenVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "who":                                                                                                                 // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode whoVar = new ElementNode(this, null, typeof(ResourceReference), nameof(Signature.Who));                     // CodeGeneration.cs:301
                    this.children.Add("who", whoVar);                                                                                       // CodeGeneration.cs:302
                    return whoVar;                                                                                                          // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "onBehalfOf":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode onBehalfOfVar = new ElementNode(this, null, typeof(ResourceReference), nameof(Signature.OnBehalfOf));       // CodeGeneration.cs:301
                    this.children.Add("onBehalfOf", onBehalfOfVar);                                                                         // CodeGeneration.cs:302
                    return onBehalfOfVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "targetFormat":                                                                                                        // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode targetFormatVar = new ElementNode(this, null, typeof(Code), nameof(Signature.TargetFormatElement));         // CodeGeneration.cs:301
                    this.children.Add("targetFormat", targetFormatVar);                                                                     // CodeGeneration.cs:302
                    return targetFormatVar;                                                                                                 // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "sigFormat":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode sigFormatVar = new ElementNode(this, null, typeof(Code), nameof(Signature.SigFormatElement));               // CodeGeneration.cs:301
                    this.children.Add("sigFormat", sigFormatVar);                                                                           // CodeGeneration.cs:302
                    return sigFormatVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "data":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode dataVar = new ElementNode(this, null, typeof(Base64Binary), nameof(Signature.DataElement));                 // CodeGeneration.cs:301
                    this.children.Add("data", dataVar);                                                                                     // CodeGeneration.cs:302
                    return dataVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Signature.ElementId));                           // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Signature.Extension));           // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildAge(String childName)                                                                                          // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(Age.ValueElement));                      // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "comparator":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), nameof(Age.ComparatorElement));// CodeGeneration.cs:301
                    this.children.Add("comparator", comparatorVar);                                                                         // CodeGeneration.cs:302
                    return comparatorVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "unit":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), nameof(Age.UnitElement));                         // CodeGeneration.cs:301
                    this.children.Add("unit", unitVar);                                                                                     // CodeGeneration.cs:302
                    return unitVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "system":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), nameof(Age.SystemElement));                        // CodeGeneration.cs:301
                    this.children.Add("system", systemVar);                                                                                 // CodeGeneration.cs:302
                    return systemVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "code":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode codeVar = new ElementNode(this, null, typeof(Code), nameof(Age.CodeElement));                               // CodeGeneration.cs:301
                    this.children.Add("code", codeVar);                                                                                     // CodeGeneration.cs:302
                    return codeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Age.ElementId));                                 // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Age.Extension));                 // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildDistance(String childName)                                                                                     // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(Distance.ValueElement));                 // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "comparator":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), nameof(Distance.ComparatorElement));// CodeGeneration.cs:301
                    this.children.Add("comparator", comparatorVar);                                                                         // CodeGeneration.cs:302
                    return comparatorVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "unit":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), nameof(Distance.UnitElement));                    // CodeGeneration.cs:301
                    this.children.Add("unit", unitVar);                                                                                     // CodeGeneration.cs:302
                    return unitVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "system":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), nameof(Distance.SystemElement));                   // CodeGeneration.cs:301
                    this.children.Add("system", systemVar);                                                                                 // CodeGeneration.cs:302
                    return systemVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "code":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode codeVar = new ElementNode(this, null, typeof(Code), nameof(Distance.CodeElement));                          // CodeGeneration.cs:301
                    this.children.Add("code", codeVar);                                                                                     // CodeGeneration.cs:302
                    return codeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Distance.ElementId));                            // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Distance.Extension));            // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildDuration(String childName)                                                                                     // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(Duration.ValueElement));                 // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "comparator":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), nameof(Duration.ComparatorElement));// CodeGeneration.cs:301
                    this.children.Add("comparator", comparatorVar);                                                                         // CodeGeneration.cs:302
                    return comparatorVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "unit":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), nameof(Duration.UnitElement));                    // CodeGeneration.cs:301
                    this.children.Add("unit", unitVar);                                                                                     // CodeGeneration.cs:302
                    return unitVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "system":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), nameof(Duration.SystemElement));                   // CodeGeneration.cs:301
                    this.children.Add("system", systemVar);                                                                                 // CodeGeneration.cs:302
                    return systemVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "code":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode codeVar = new ElementNode(this, null, typeof(Code), nameof(Duration.CodeElement));                          // CodeGeneration.cs:301
                    this.children.Add("code", codeVar);                                                                                     // CodeGeneration.cs:302
                    return codeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Duration.ElementId));                            // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Duration.Extension));            // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildCount(String childName)                                                                                        // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(Count.ValueElement));                    // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "comparator":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), nameof(Count.ComparatorElement));// CodeGeneration.cs:301
                    this.children.Add("comparator", comparatorVar);                                                                         // CodeGeneration.cs:302
                    return comparatorVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "unit":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), nameof(Count.UnitElement));                       // CodeGeneration.cs:301
                    this.children.Add("unit", unitVar);                                                                                     // CodeGeneration.cs:302
                    return unitVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "system":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), nameof(Count.SystemElement));                      // CodeGeneration.cs:301
                    this.children.Add("system", systemVar);                                                                                 // CodeGeneration.cs:302
                    return systemVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "code":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode codeVar = new ElementNode(this, null, typeof(Code), nameof(Count.CodeElement));                             // CodeGeneration.cs:301
                    this.children.Add("code", codeVar);                                                                                     // CodeGeneration.cs:302
                    return codeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Count.ElementId));                               // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Count.Extension));               // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildMoneyQuantity(String childName)                                                                                // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(MoneyQuantity.ValueElement));            // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "comparator":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), nameof(MoneyQuantity.ComparatorElement));// CodeGeneration.cs:301
                    this.children.Add("comparator", comparatorVar);                                                                         // CodeGeneration.cs:302
                    return comparatorVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "unit":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), nameof(MoneyQuantity.UnitElement));               // CodeGeneration.cs:301
                    this.children.Add("unit", unitVar);                                                                                     // CodeGeneration.cs:302
                    return unitVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "system":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), nameof(MoneyQuantity.SystemElement));              // CodeGeneration.cs:301
                    this.children.Add("system", systemVar);                                                                                 // CodeGeneration.cs:302
                    return systemVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "code":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode codeVar = new ElementNode(this, null, typeof(Code), nameof(MoneyQuantity.CodeElement));                     // CodeGeneration.cs:301
                    this.children.Add("code", codeVar);                                                                                     // CodeGeneration.cs:302
                    return codeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(MoneyQuantity.ElementId));                       // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(MoneyQuantity.Extension));       // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildSimpleQuantity(String childName)                                                                               // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), nameof(SimpleQuantity.ValueElement));           // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "comparator":                                                                                                          // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), nameof(SimpleQuantity.ComparatorElement));// CodeGeneration.cs:301
                    this.children.Add("comparator", comparatorVar);                                                                         // CodeGeneration.cs:302
                    return comparatorVar;                                                                                                   // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "unit":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), nameof(SimpleQuantity.UnitElement));              // CodeGeneration.cs:301
                    this.children.Add("unit", unitVar);                                                                                     // CodeGeneration.cs:302
                    return unitVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "system":                                                                                                              // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), nameof(SimpleQuantity.SystemElement));             // CodeGeneration.cs:301
                    this.children.Add("system", systemVar);                                                                                 // CodeGeneration.cs:302
                    return systemVar;                                                                                                       // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "code":                                                                                                                // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode codeVar = new ElementNode(this, null, typeof(Code), nameof(SimpleQuantity.CodeElement));                    // CodeGeneration.cs:301
                    this.children.Add("code", codeVar);                                                                                     // CodeGeneration.cs:302
                    return codeVar;                                                                                                         // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(SimpleQuantity.ElementId));                      // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(SimpleQuantity.Extension));      // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildExtension(String childName)                                                                                    // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            switch (childName)                                                                                                              // CodeGeneration.cs:288
            {                                                                                                                               // CodeGeneration.cs:289
                case "url":                                                                                                                 // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode urlVar = new ElementNode(this, null, typeof(string), nameof(Extension.Url));                                // CodeGeneration.cs:301
                    this.children.Add("url", urlVar);                                                                                       // CodeGeneration.cs:302
                    return urlVar;                                                                                                          // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "value":                                                                                                               // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode valueVar = new ElementNode(this, null, typeof(Element), nameof(Extension.Value));                           // CodeGeneration.cs:301
                    this.children.Add("value", valueVar);                                                                                   // CodeGeneration.cs:302
                    return valueVar;                                                                                                        // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "id":                                                                                                                  // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode idVar = new ElementNode(this, null, typeof(string), nameof(Extension.ElementId));                           // CodeGeneration.cs:301
                    this.children.Add("id", idVar);                                                                                         // CodeGeneration.cs:302
                    return idVar;                                                                                                           // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                case "extension":                                                                                                           // CodeGeneration.cs:299
                {                                                                                                                           // CodeGeneration.cs:300
                    ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), nameof(Extension.Extension));           // CodeGeneration.cs:301
                    this.children.Add("extension", extensionVar);                                                                           // CodeGeneration.cs:302
                    return extensionVar;                                                                                                    // CodeGeneration.cs:303
                }                                                                                                                           // CodeGeneration.cs:304
                default: return null;                                                                                                       // CodeGeneration.cs:310
            }                                                                                                                               // CodeGeneration.cs:311
        }                                                                                                                                   // CodeGeneration.cs:312
    }                                                                                                                                       // CodeGeneration.cs:348
}                                                                                                                                           // CodeGeneration.cs:349
