using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Complex
{
    #region Json
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
    #endregion
    /// <summary>
    /// Fhir complex 'Signature'
    /// </summary>
    // 0. Signature
    public partial class Type_Signature : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. Signature.type
        public ElementDefinitionInfo Element_Type;
        // 2. Signature.when
        public ElementDefinitionInfo Element_When;
        // 3. Signature.who
        public ElementDefinitionInfo Element_Who;
        // 4. Signature.onBehalfOf
        public ElementDefinitionInfo Element_OnBehalfOf;
        // 5. Signature.targetFormat
        public ElementDefinitionInfo Element_TargetFormat;
        // 6. Signature.sigFormat
        public ElementDefinitionInfo Element_SigFormat;
        // 7. Signature.data
        public ElementDefinitionInfo Element_Data;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Signature",
                ElementId = "Signature"
            });
            Element_Type.Write(sDef);
            Element_When.Write(sDef);
            Element_Who.Write(sDef);
            Element_OnBehalfOf.Write(sDef);
            Element_TargetFormat.Write(sDef);
            Element_SigFormat.Write(sDef);
            Element_Data.Write(sDef);
        }
        
        public Type_Signature()
        {
            {
                // 1. Signature.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Signature.type",
                    Id = "Signature.type",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Coding
                        {
                        }
                    }
                };
            }
            {
                // 2. Signature.when
                this.Element_When = new ElementDefinitionInfo
                {
                    Name = "Element_When",
                    Path= "Signature.when",
                    Id = "Signature.when",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                        {
                        }
                    }
                };
            }
            {
                // 3. Signature.who
                this.Element_Who = new ElementDefinitionInfo
                {
                    Name = "Element_Who",
                    Path= "Signature.who",
                    Id = "Signature.who",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 4. Signature.onBehalfOf
                this.Element_OnBehalfOf = new ElementDefinitionInfo
                {
                    Name = "Element_OnBehalfOf",
                    Path= "Signature.onBehalfOf",
                    Id = "Signature.onBehalfOf",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 5. Signature.targetFormat
                this.Element_TargetFormat = new ElementDefinitionInfo
                {
                    Name = "Element_TargetFormat",
                    Path= "Signature.targetFormat",
                    Id = "Signature.targetFormat",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 6. Signature.sigFormat
                this.Element_SigFormat = new ElementDefinitionInfo
                {
                    Name = "Element_SigFormat",
                    Path= "Signature.sigFormat",
                    Id = "Signature.sigFormat",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 7. Signature.data
                this.Element_Data = new ElementDefinitionInfo
                {
                    Name = "Element_Data",
                    Path= "Signature.data",
                    Id = "Signature.data",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary
                        {
                        }
                    }
                };
            }
        }
    }
}
