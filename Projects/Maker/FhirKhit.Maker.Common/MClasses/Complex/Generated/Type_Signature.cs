using System;                                                                                                                               // MakerGen.cs:498
using System.Diagnostics;                                                                                                                   // MakerGen.cs:499
using System.IO;                                                                                                                            // MakerGen.cs:500
using System.Linq;                                                                                                                          // MakerGen.cs:501
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:502
                                                                                                                                            // MakerGen.cs:503
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:504
{                                                                                                                                           // MakerGen.cs:505
    #region Json                                                                                                                            // MakerGen.cs:506
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Signature",
      "url": "http://hl7.org/fhir/StructureDefinition/Signature",
      "version": "4.0.0",
      "name": "Signature",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Signature Type: A signature along with supporting context. The signature may be a digital signature that is cryptographic in nature, or some other signature acceptable to the domain. This other signature may be as simple as a graphical image representing a hand-written signature, or a signature ceremony Different signature approaches have different utilities.",
      "purpose": "There are a number of places where content must be signed in healthcare.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Signature",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Signature",
            "path": "Signature",
            "short": "A Signature - XML DigSig, JWS, Graphical image of signature, etc.",
            "definition": "A signature along with supporting context. The signature may be a digital signature that is cryptographic in nature, or some other signature acceptable to the domain. This other signature may be as simple as a graphical image representing a hand-written signature, or a signature ceremony Different signature approaches have different utilities.",
            "comment": "The elements of the Signature Resource are for ease of access of these elements. For digital signatures (Xml DigSig, JWS), the non-repudiation proof comes from the Signature  validation, which includes validation of the referenced objects (e.g. Resources) (a.k.a., Content) in the XML-Signature Detached form.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Signature.type",
            "path": "Signature.type",
            "short": "Indication of the reason the entity signed the object(s)",
            "definition": "An indication of the reason that the entity signed this document. This may be explicitly included as part of the signature information and can be used when determining accountability for various actions concerning the document.",
            "comment": "Examples include attesting to: authorship, correct transcription, and witness of specific event. Also known as a &quot;Commitment Type Indication&quot;.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SignatureType"
                }
              ],
              "strength": "preferred",
              "description": "An indication of the reason that an entity signed the object.",
              "valueSet": "http://hl7.org/fhir/ValueSet/signature-type"
            }
          },
          {
            "id": "Signature.when",
            "path": "Signature.when",
            "short": "When the signature was created",
            "definition": "When the digital signature was signed.",
            "comment": "This should agree with the information in the signature.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "instant"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Signature.who",
            "path": "Signature.who",
            "short": "Who signed",
            "definition": "A reference to an application-usable description of the identity that signed  (e.g. the signature used their private key).",
            "comment": "This should agree with the information in the signature.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Signature.onBehalfOf",
            "path": "Signature.onBehalfOf",
            "short": "The party represented",
            "definition": "A reference to an application-usable description of the identity that is represented by the signature.",
            "comment": "The party that can't sign. For example a child.",
            "requirements": "used when the signature is on behalf of a non-signer.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Signature.targetFormat",
            "path": "Signature.targetFormat",
            "short": "The technical format of the signed resources",
            "definition": "A mime type that indicates the technical format of the target resources signed by the signature.",
            "comment": "\"xml\", \"json\" and \"ttl\" are allowed, which describe the simple encodings described in the specification (and imply appropriate bundle support). Otherwise, mime types are legal here.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MimeType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The mime type of an attachment. Any valid mime type is allowed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/mimetypes|4.0.0"
            }
          },
          {
            "id": "Signature.sigFormat",
            "path": "Signature.sigFormat",
            "short": "The technical format of the signature",
            "definition": "A mime type that indicates the technical format of the signature. Important mime types are application/signature+xml for X ML DigSig, application/jose for JWS, and image/* for a graphical image of a signature, etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MimeType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The mime type of an attachment. Any valid mime type is allowed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/mimetypes|4.0.0"
            }
          },
          {
            "id": "Signature.data",
            "path": "Signature.data",
            "short": "The actual signature content (XML DigSig. JWS, picture, etc.)",
            "definition": "The base64 encoding of the Signature content. When signature is not recorded electronically this element would be empty.",
            "comment": "Where the signature type is an XML DigSig, the signed content is a FHIR Resource(s), the signature is of the XML form of the Resource(s) using  XML-Signature (XMLDIG) \"Detached Signature\" form.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "base64Binary"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:510
    /// <summary>
    /// Fhir complex 'Signature'
    /// </summary>
    // 0. Signature
    public class Type_Signature : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. Signature.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 2. Signature.when
        public ElementDefinitionInfo Element_When;                                                                                          // MakerGen.cs:219
        // 3. Signature.who
        public ElementDefinitionInfo Element_Who;                                                                                           // MakerGen.cs:219
        // 4. Signature.onBehalfOf
        public ElementDefinitionInfo Element_OnBehalfOf;                                                                                    // MakerGen.cs:219
        // 5. Signature.targetFormat
        public ElementDefinitionInfo Element_TargetFormat;                                                                                  // MakerGen.cs:219
        // 6. Signature.sigFormat
        public ElementDefinitionInfo Element_SigFormat;                                                                                     // MakerGen.cs:219
        // 7. Signature.data
        public ElementDefinitionInfo Element_Data;                                                                                          // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "Signature",                                                                                                         // MakerGen.cs:395
                ElementId = "Signature"                                                                                                     // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_When.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Who.Write(sDef);                                                                                                        // MakerGen.cs:223
            Element_OnBehalfOf.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_TargetFormat.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_SigFormat.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Data.Write(sDef);                                                                                                       // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Type_Signature()                                                                                                             // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. Signature.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "Signature.type",                                                                                                 // MakerGen.cs:239
                    Id = "Signature.type",                                                                                                  // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. Signature.when
                this.Element_When = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_When",                                                                                                  // MakerGen.cs:238
                    Path= "Signature.when",                                                                                                 // MakerGen.cs:239
                    Id = "Signature.when",                                                                                                  // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. Signature.who
                this.Element_Who = new ElementDefinitionInfo                                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Who",                                                                                                   // MakerGen.cs:238
                    Path= "Signature.who",                                                                                                  // MakerGen.cs:239
                    Id = "Signature.who",                                                                                                   // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. Signature.onBehalfOf
                this.Element_OnBehalfOf = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_OnBehalfOf",                                                                                            // MakerGen.cs:238
                    Path= "Signature.onBehalfOf",                                                                                           // MakerGen.cs:239
                    Id = "Signature.onBehalfOf",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. Signature.targetFormat
                this.Element_TargetFormat = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_TargetFormat",                                                                                          // MakerGen.cs:238
                    Path= "Signature.targetFormat",                                                                                         // MakerGen.cs:239
                    Id = "Signature.targetFormat",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. Signature.sigFormat
                this.Element_SigFormat = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SigFormat",                                                                                             // MakerGen.cs:238
                    Path= "Signature.sigFormat",                                                                                            // MakerGen.cs:239
                    Id = "Signature.sigFormat",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. Signature.data
                this.Element_Data = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Data",                                                                                                  // MakerGen.cs:238
                    Path= "Signature.data",                                                                                                 // MakerGen.cs:239
                    Id = "Signature.data",                                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary                                                          // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:515
