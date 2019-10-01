using System;                                                                                                                               // MakerGen.cs:499
using System.Diagnostics;                                                                                                                   // MakerGen.cs:500
using System.IO;                                                                                                                            // MakerGen.cs:501
using System.Linq;                                                                                                                          // MakerGen.cs:502
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:503
                                                                                                                                            // MakerGen.cs:504
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:505
{                                                                                                                                           // MakerGen.cs:506
    #region Json                                                                                                                            // MakerGen.cs:507
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
    #endregion                                                                                                                              // MakerGen.cs:511
    /// <summary>
    /// Fhir complex 'Signature'
    /// </summary>
    // 0. Signature
    public class Signature : FhirKhit.Maker.Common.Complex.ComplexBase                                                                      // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Signature_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                       // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. Signature.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:236
            // 2. Signature.when
            public ElementDefinitionInfo When;                                                                                              // MakerGen.cs:236
            // 3. Signature.who
            public ElementDefinitionInfo Who;                                                                                               // MakerGen.cs:236
            // 4. Signature.onBehalfOf
            public ElementDefinitionInfo OnBehalfOf;                                                                                        // MakerGen.cs:236
            // 5. Signature.targetFormat
            public ElementDefinitionInfo TargetFormat;                                                                                      // MakerGen.cs:236
            // 6. Signature.sigFormat
            public ElementDefinitionInfo SigFormat;                                                                                         // MakerGen.cs:236
            // 7. Signature.data
            public ElementDefinitionInfo Data;                                                                                              // MakerGen.cs:236
            public Signature_Elements()                                                                                                     // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Signature.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Type",                                                                                                      // MakerGen.cs:255
                        Path= "Signature.type",                                                                                             // MakerGen.cs:256
                        Id = "Signature.type",                                                                                              // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. Signature.when
                    this.When = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "When",                                                                                                      // MakerGen.cs:255
                        Path= "Signature.when",                                                                                             // MakerGen.cs:256
                        Id = "Signature.when",                                                                                              // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Instant                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. Signature.who
                    this.Who = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Who",                                                                                                       // MakerGen.cs:255
                        Path= "Signature.who",                                                                                              // MakerGen.cs:256
                        Id = "Signature.who",                                                                                               // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. Signature.onBehalfOf
                    this.OnBehalfOf = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "OnBehalfOf",                                                                                                // MakerGen.cs:255
                        Path= "Signature.onBehalfOf",                                                                                       // MakerGen.cs:256
                        Id = "Signature.onBehalfOf",                                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. Signature.targetFormat
                    this.TargetFormat = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "TargetFormat",                                                                                              // MakerGen.cs:255
                        Path= "Signature.targetFormat",                                                                                     // MakerGen.cs:256
                        Id = "Signature.targetFormat",                                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. Signature.sigFormat
                    this.SigFormat = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "SigFormat",                                                                                                 // MakerGen.cs:255
                        Path= "Signature.sigFormat",                                                                                        // MakerGen.cs:256
                        Id = "Signature.sigFormat",                                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. Signature.data
                    this.Data = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Data",                                                                                                      // MakerGen.cs:255
                        Path= "Signature.data",                                                                                             // MakerGen.cs:256
                        Id = "Signature.data",                                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Base64Binary                                                                // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Type.Write(sDef);                                                                                                           // MakerGen.cs:240
                When.Write(sDef);                                                                                                           // MakerGen.cs:240
                Who.Write(sDef);                                                                                                            // MakerGen.cs:240
                OnBehalfOf.Write(sDef);                                                                                                     // MakerGen.cs:240
                TargetFormat.Write(sDef);                                                                                                   // MakerGen.cs:240
                SigFormat.Write(sDef);                                                                                                      // MakerGen.cs:240
                Data.Write(sDef);                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Signature_Elements Elements { get; }                                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Signature()                                                                                                                  // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Signature_Elements();                                                                                       // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
