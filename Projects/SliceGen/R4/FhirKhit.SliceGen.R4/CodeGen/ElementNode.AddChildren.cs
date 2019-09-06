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
                                                                                                                                            // CodeGeneration.cs:332
namespace FhirKhit.SliceGen.R4
{                                                                                                                                           // CodeGeneration.cs:334
    public partial class ElementNode                                                                                                        // CodeGeneration.cs:335
    {                                                                                                                                       // CodeGeneration.cs:336
        /// <summary>
        /// generate code for each fhir element. Makes sure it compiles.
        /// </summary>
        public void AddCommonChildren()                                                                                                     // CodeGeneration.cs:350
        {                                                                                                                                   // CodeGeneration.cs:351
            switch (this.FhirItemType.FriendlyName())                                                                                       // CodeGeneration.cs:352
            {                                                                                                                               // CodeGeneration.cs:353
                case "Ratio": AddChildrenRatio(); break;                                                                                    // CodeGeneration.cs:280
                case "Period": AddChildrenPeriod(); break;                                                                                  // CodeGeneration.cs:280
                case "Range": AddChildrenRange(); break;                                                                                    // CodeGeneration.cs:280
                case "Attachment": AddChildrenAttachment(); break;                                                                          // CodeGeneration.cs:280
                case "Identifier": AddChildrenIdentifier(); break;                                                                          // CodeGeneration.cs:280
                case "Annotation": AddChildrenAnnotation(); break;                                                                          // CodeGeneration.cs:280
                case "HumanName": AddChildrenHumanName(); break;                                                                            // CodeGeneration.cs:280
                case "CodeableConcept": AddChildrenCodeableConcept(); break;                                                                // CodeGeneration.cs:280
                case "ContactPoint": AddChildrenContactPoint(); break;                                                                      // CodeGeneration.cs:280
                case "Coding": AddChildrenCoding(); break;                                                                                  // CodeGeneration.cs:280
                case "Money": AddChildrenMoney(); break;                                                                                    // CodeGeneration.cs:280
                case "Address": AddChildrenAddress(); break;                                                                                // CodeGeneration.cs:280
                case "Timing": AddChildrenTiming(); break;                                                                                  // CodeGeneration.cs:280
                case "Quantity": AddChildrenQuantity(); break;                                                                              // CodeGeneration.cs:280
                case "SampledData": AddChildrenSampledData(); break;                                                                        // CodeGeneration.cs:280
                case "Signature": AddChildrenSignature(); break;                                                                            // CodeGeneration.cs:280
                case "Age": AddChildrenAge(); break;                                                                                        // CodeGeneration.cs:280
                case "Distance": AddChildrenDistance(); break;                                                                              // CodeGeneration.cs:280
                case "Duration": AddChildrenDuration(); break;                                                                              // CodeGeneration.cs:280
                case "Count": AddChildrenCount(); break;                                                                                    // CodeGeneration.cs:280
                case "MoneyQuantity": AddChildrenMoneyQuantity(); break;                                                                    // CodeGeneration.cs:280
                case "SimpleQuantity": AddChildrenSimpleQuantity(); break;                                                                  // CodeGeneration.cs:280
            }                                                                                                                               // CodeGeneration.cs:381
        }                                                                                                                                   // CodeGeneration.cs:382
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenRatio()                                                                                                             // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode numeratorVar = new ElementNode(this, null, typeof(Quantity), "Quantity");                                       // CodeGeneration.cs:298
                this.children.Add("numerator", numeratorVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode denominatorVar = new ElementNode(this, null, typeof(Quantity), "Quantity");                                     // CodeGeneration.cs:298
                this.children.Add("denominator", denominatorVar);                                                                           // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenPeriod()                                                                                                            // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode startVar = new ElementNode(this, null, typeof(FhirDateTime), "FhirDateTime");                                   // CodeGeneration.cs:298
                this.children.Add("start", startVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode endVar = new ElementNode(this, null, typeof(FhirDateTime), "FhirDateTime");                                     // CodeGeneration.cs:298
                this.children.Add("end", endVar);                                                                                           // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenRange()                                                                                                             // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode lowVar = new ElementNode(this, null, typeof(SimpleQuantity), "SimpleQuantity");                                 // CodeGeneration.cs:298
                this.children.Add("low", lowVar);                                                                                           // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode highVar = new ElementNode(this, null, typeof(SimpleQuantity), "SimpleQuantity");                                // CodeGeneration.cs:298
                this.children.Add("high", highVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenAttachment()                                                                                                        // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode contentTypeVar = new ElementNode(this, null, typeof(Code), "Code");                                             // CodeGeneration.cs:298
                this.children.Add("contentType", contentTypeVar);                                                                           // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode languageVar = new ElementNode(this, null, typeof(Code), "Code");                                                // CodeGeneration.cs:298
                this.children.Add("language", languageVar);                                                                                 // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode dataVar = new ElementNode(this, null, typeof(Base64Binary), "Base64Binary");                                    // CodeGeneration.cs:298
                this.children.Add("data", dataVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode urlVar = new ElementNode(this, null, typeof(FhirUrl), "FhirUrl");                                               // CodeGeneration.cs:298
                this.children.Add("url", urlVar);                                                                                           // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode sizeVar = new ElementNode(this, null, typeof(UnsignedInt), "UnsignedInt");                                      // CodeGeneration.cs:298
                this.children.Add("size", sizeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode hashVar = new ElementNode(this, null, typeof(Base64Binary), "Base64Binary");                                    // CodeGeneration.cs:298
                this.children.Add("hash", hashVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode titleVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                       // CodeGeneration.cs:298
                this.children.Add("title", titleVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode creationVar = new ElementNode(this, null, typeof(FhirDateTime), "FhirDateTime");                                // CodeGeneration.cs:298
                this.children.Add("creation", creationVar);                                                                                 // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenIdentifier()                                                                                                        // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode useVar = new ElementNode(this, null, typeof(Code<Identifier.IdentifierUse>), "Code<Identifier.IdentifierUse>"); // CodeGeneration.cs:298
                this.children.Add("use", useVar);                                                                                           // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode typeVar = new ElementNode(this, null, typeof(CodeableConcept), "CodeableConcept");                              // CodeGeneration.cs:298
                this.children.Add("type", typeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), "FhirUri");                                            // CodeGeneration.cs:298
                this.children.Add("system", systemVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode valueVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                       // CodeGeneration.cs:298
                this.children.Add("value", valueVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode periodVar = new ElementNode(this, null, typeof(Period), "Period");                                              // CodeGeneration.cs:298
                this.children.Add("period", periodVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode assignerVar = new ElementNode(this, null, typeof(ResourceReference), "ResourceReference");                      // CodeGeneration.cs:298
                this.children.Add("assigner", assignerVar);                                                                                 // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenAnnotation()                                                                                                        // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode authorVar = new ElementNode(this, null, typeof(Element), "Element");                                            // CodeGeneration.cs:298
                this.children.Add("author", authorVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode timeVar = new ElementNode(this, null, typeof(FhirDateTime), "FhirDateTime");                                    // CodeGeneration.cs:298
                this.children.Add("time", timeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode textVar = new ElementNode(this, null, typeof(Markdown), "Markdown");                                            // CodeGeneration.cs:298
                this.children.Add("text", textVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenHumanName()                                                                                                         // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode useVar = new ElementNode(this, null, typeof(Code<HumanName.NameUse>), "Code<HumanName.NameUse>");               // CodeGeneration.cs:298
                this.children.Add("use", useVar);                                                                                           // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode textVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("text", textVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode familyVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                      // CodeGeneration.cs:298
                this.children.Add("family", familyVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode givenVar = new ElementNode(this, null, typeof(List<FhirString>), "List<FhirString>");                           // CodeGeneration.cs:298
                this.children.Add("given", givenVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode prefixVar = new ElementNode(this, null, typeof(List<FhirString>), "List<FhirString>");                          // CodeGeneration.cs:298
                this.children.Add("prefix", prefixVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode suffixVar = new ElementNode(this, null, typeof(List<FhirString>), "List<FhirString>");                          // CodeGeneration.cs:298
                this.children.Add("suffix", suffixVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode periodVar = new ElementNode(this, null, typeof(Period), "Period");                                              // CodeGeneration.cs:298
                this.children.Add("period", periodVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenCodeableConcept()                                                                                                   // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode codingVar = new ElementNode(this, null, typeof(List<Coding>), "List<Coding>");                                  // CodeGeneration.cs:298
                this.children.Add("coding", codingVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode textVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("text", textVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenContactPoint()                                                                                                      // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode systemVar = new ElementNode(this, null, typeof(Code<ContactPoint.ContactPointSystem>), "Code<ContactPoint.ContactPointSystem>");// CodeGeneration.cs:298
                this.children.Add("system", systemVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode valueVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                       // CodeGeneration.cs:298
                this.children.Add("value", valueVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode useVar = new ElementNode(this, null, typeof(Code<ContactPoint.ContactPointUse>), "Code<ContactPoint.ContactPointUse>");// CodeGeneration.cs:298
                this.children.Add("use", useVar);                                                                                           // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode rankVar = new ElementNode(this, null, typeof(PositiveInt), "PositiveInt");                                      // CodeGeneration.cs:298
                this.children.Add("rank", rankVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode periodVar = new ElementNode(this, null, typeof(Period), "Period");                                              // CodeGeneration.cs:298
                this.children.Add("period", periodVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenCoding()                                                                                                            // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), "FhirUri");                                            // CodeGeneration.cs:298
                this.children.Add("system", systemVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode versionVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                     // CodeGeneration.cs:298
                this.children.Add("version", versionVar);                                                                                   // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode codeVar = new ElementNode(this, null, typeof(Code), "Code");                                                    // CodeGeneration.cs:298
                this.children.Add("code", codeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode displayVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                     // CodeGeneration.cs:298
                this.children.Add("display", displayVar);                                                                                   // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode userSelectedVar = new ElementNode(this, null, typeof(FhirBoolean), "FhirBoolean");                              // CodeGeneration.cs:298
                this.children.Add("userSelected", userSelectedVar);                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenMoney()                                                                                                             // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                     // CodeGeneration.cs:298
                this.children.Add("value", valueVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode currencyVar = new ElementNode(this, null, typeof(Code<Money.Currencies>), "Code<Money.Currencies>");            // CodeGeneration.cs:298
                this.children.Add("currency", currencyVar);                                                                                 // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenAddress()                                                                                                           // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode useVar = new ElementNode(this, null, typeof(Code<Address.AddressUse>), "Code<Address.AddressUse>");             // CodeGeneration.cs:298
                this.children.Add("use", useVar);                                                                                           // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode typeVar = new ElementNode(this, null, typeof(Code<Address.AddressType>), "Code<Address.AddressType>");          // CodeGeneration.cs:298
                this.children.Add("type", typeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode textVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("text", textVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode lineVar = new ElementNode(this, null, typeof(List<FhirString>), "List<FhirString>");                            // CodeGeneration.cs:298
                this.children.Add("line", lineVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode cityVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("city", cityVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode districtVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                    // CodeGeneration.cs:298
                this.children.Add("district", districtVar);                                                                                 // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode stateVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                       // CodeGeneration.cs:298
                this.children.Add("state", stateVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode postalCodeVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                  // CodeGeneration.cs:298
                this.children.Add("postalCode", postalCodeVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode countryVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                     // CodeGeneration.cs:298
                this.children.Add("country", countryVar);                                                                                   // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode periodVar = new ElementNode(this, null, typeof(Period), "Period");                                              // CodeGeneration.cs:298
                this.children.Add("period", periodVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenTiming()                                                                                                            // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode eventVar = new ElementNode(this, null, typeof(List<FhirDateTime>), "List<FhirDateTime>");                       // CodeGeneration.cs:298
                this.children.Add("event", eventVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode repeatVar = new ElementNode(this, null, typeof(Timing.RepeatComponent), "Timing.RepeatComponent");              // CodeGeneration.cs:298
                this.children.Add("repeat", repeatVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode codeVar = new ElementNode(this, null, typeof(CodeableConcept), "CodeableConcept");                              // CodeGeneration.cs:298
                this.children.Add("code", codeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode modifierExtensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                 // CodeGeneration.cs:298
                this.children.Add("modifierExtension", modifierExtensionVar);                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenQuantity()                                                                                                          // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                     // CodeGeneration.cs:298
                this.children.Add("value", valueVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), "Code<Quantity.QuantityComparator>");// CodeGeneration.cs:298
                this.children.Add("comparator", comparatorVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("unit", unitVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), "FhirUri");                                            // CodeGeneration.cs:298
                this.children.Add("system", systemVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode codeVar = new ElementNode(this, null, typeof(Code), "Code");                                                    // CodeGeneration.cs:298
                this.children.Add("code", codeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenSampledData()                                                                                                       // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode originVar = new ElementNode(this, null, typeof(SimpleQuantity), "SimpleQuantity");                              // CodeGeneration.cs:298
                this.children.Add("origin", originVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode periodVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                    // CodeGeneration.cs:298
                this.children.Add("period", periodVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode factorVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                    // CodeGeneration.cs:298
                this.children.Add("factor", factorVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode lowerLimitVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                // CodeGeneration.cs:298
                this.children.Add("lowerLimit", lowerLimitVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode upperLimitVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                // CodeGeneration.cs:298
                this.children.Add("upperLimit", upperLimitVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode dimensionsVar = new ElementNode(this, null, typeof(PositiveInt), "PositiveInt");                                // CodeGeneration.cs:298
                this.children.Add("dimensions", dimensionsVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode dataVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("data", dataVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenSignature()                                                                                                         // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode typeVar = new ElementNode(this, null, typeof(List<Coding>), "List<Coding>");                                    // CodeGeneration.cs:298
                this.children.Add("type", typeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode whenVar = new ElementNode(this, null, typeof(Instant), "Instant");                                              // CodeGeneration.cs:298
                this.children.Add("when", whenVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode whoVar = new ElementNode(this, null, typeof(ResourceReference), "ResourceReference");                           // CodeGeneration.cs:298
                this.children.Add("who", whoVar);                                                                                           // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode onBehalfOfVar = new ElementNode(this, null, typeof(ResourceReference), "ResourceReference");                    // CodeGeneration.cs:298
                this.children.Add("onBehalfOf", onBehalfOfVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode targetFormatVar = new ElementNode(this, null, typeof(Code), "Code");                                            // CodeGeneration.cs:298
                this.children.Add("targetFormat", targetFormatVar);                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode sigFormatVar = new ElementNode(this, null, typeof(Code), "Code");                                               // CodeGeneration.cs:298
                this.children.Add("sigFormat", sigFormatVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode dataVar = new ElementNode(this, null, typeof(Base64Binary), "Base64Binary");                                    // CodeGeneration.cs:298
                this.children.Add("data", dataVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenAge()                                                                                                               // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                     // CodeGeneration.cs:298
                this.children.Add("value", valueVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), "Code<Quantity.QuantityComparator>");// CodeGeneration.cs:298
                this.children.Add("comparator", comparatorVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("unit", unitVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), "FhirUri");                                            // CodeGeneration.cs:298
                this.children.Add("system", systemVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode codeVar = new ElementNode(this, null, typeof(Code), "Code");                                                    // CodeGeneration.cs:298
                this.children.Add("code", codeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenDistance()                                                                                                          // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                     // CodeGeneration.cs:298
                this.children.Add("value", valueVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), "Code<Quantity.QuantityComparator>");// CodeGeneration.cs:298
                this.children.Add("comparator", comparatorVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("unit", unitVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), "FhirUri");                                            // CodeGeneration.cs:298
                this.children.Add("system", systemVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode codeVar = new ElementNode(this, null, typeof(Code), "Code");                                                    // CodeGeneration.cs:298
                this.children.Add("code", codeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenDuration()                                                                                                          // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                     // CodeGeneration.cs:298
                this.children.Add("value", valueVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), "Code<Quantity.QuantityComparator>");// CodeGeneration.cs:298
                this.children.Add("comparator", comparatorVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("unit", unitVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), "FhirUri");                                            // CodeGeneration.cs:298
                this.children.Add("system", systemVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode codeVar = new ElementNode(this, null, typeof(Code), "Code");                                                    // CodeGeneration.cs:298
                this.children.Add("code", codeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenCount()                                                                                                             // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                     // CodeGeneration.cs:298
                this.children.Add("value", valueVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), "Code<Quantity.QuantityComparator>");// CodeGeneration.cs:298
                this.children.Add("comparator", comparatorVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("unit", unitVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), "FhirUri");                                            // CodeGeneration.cs:298
                this.children.Add("system", systemVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode codeVar = new ElementNode(this, null, typeof(Code), "Code");                                                    // CodeGeneration.cs:298
                this.children.Add("code", codeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenMoneyQuantity()                                                                                                     // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                     // CodeGeneration.cs:298
                this.children.Add("value", valueVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), "Code<Quantity.QuantityComparator>");// CodeGeneration.cs:298
                this.children.Add("comparator", comparatorVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("unit", unitVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), "FhirUri");                                            // CodeGeneration.cs:298
                this.children.Add("system", systemVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode codeVar = new ElementNode(this, null, typeof(Code), "Code");                                                    // CodeGeneration.cs:298
                this.children.Add("code", codeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:284
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        void AddChildrenSimpleQuantity()                                                                                                    // CodeGeneration.cs:286
        {                                                                                                                                   // CodeGeneration.cs:287
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode valueVar = new ElementNode(this, null, typeof(FhirDecimal), "FhirDecimal");                                     // CodeGeneration.cs:298
                this.children.Add("value", valueVar);                                                                                       // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode comparatorVar = new ElementNode(this, null, typeof(Code<Quantity.QuantityComparator>), "Code<Quantity.QuantityComparator>");// CodeGeneration.cs:298
                this.children.Add("comparator", comparatorVar);                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode unitVar = new ElementNode(this, null, typeof(FhirString), "FhirString");                                        // CodeGeneration.cs:298
                this.children.Add("unit", unitVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode systemVar = new ElementNode(this, null, typeof(FhirUri), "FhirUri");                                            // CodeGeneration.cs:298
                this.children.Add("system", systemVar);                                                                                     // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode codeVar = new ElementNode(this, null, typeof(Code), "Code");                                                    // CodeGeneration.cs:298
                this.children.Add("code", codeVar);                                                                                         // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode idVar = new ElementNode(this, null, typeof(string), "string");                                                  // CodeGeneration.cs:298
                this.children.Add("id", idVar);                                                                                             // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
            {                                                                                                                               // CodeGeneration.cs:297
                ElementNode extensionVar = new ElementNode(this, null, typeof(List<Extension>), "List<Extension>");                         // CodeGeneration.cs:298
                this.children.Add("extension", extensionVar);                                                                               // CodeGeneration.cs:299
            }                                                                                                                               // CodeGeneration.cs:300
        }                                                                                                                                   // CodeGeneration.cs:306
    }                                                                                                                                       // CodeGeneration.cs:342
}                                                                                                                                           // CodeGeneration.cs:343
