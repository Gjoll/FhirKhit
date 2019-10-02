using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Resource
{
    #region Json
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "EnrollmentResponse",
      "url": "http://hl7.org/fhir/StructureDefinition/EnrollmentResponse",
      "version": "4.0.0",
      "name": "EnrollmentResponse",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "This resource provides enrollment and plan details from the processing of an EnrollmentRequest resource.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "EnrollmentResponse",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "EnrollmentResponse",
            "path": "EnrollmentResponse",
            "short": "EnrollmentResponse resource",
            "definition": "This resource provides enrollment and plan details from the processing of an EnrollmentRequest resource.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "EnrollmentResponse.identifier",
            "path": "EnrollmentResponse.identifier",
            "short": "Business Identifier",
            "definition": "The Response business identifier.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "EnrollmentResponse.status",
            "path": "EnrollmentResponse.status",
            "short": "active | cancelled | draft | entered-in-error",
            "definition": "The status of the resource instance.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the response as not currently valid.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "EnrollmentResponseStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/fm-status|4.0.0"
            }
          },
          {
            "id": "EnrollmentResponse.request",
            "path": "EnrollmentResponse.request",
            "short": "Claim reference",
            "definition": "Original request resource reference.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/EnrollmentRequest"
                ]
              }
            ]
          },
          {
            "id": "EnrollmentResponse.outcome",
            "path": "EnrollmentResponse.outcome",
            "short": "queued | complete | error | partial",
            "definition": "Processing status: error, complete.",
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
                  "valueString": "RemittanceOutcome"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The outcome of the processing.",
              "valueSet": "http://hl7.org/fhir/ValueSet/remittance-outcome|4.0.0"
            }
          },
          {
            "id": "EnrollmentResponse.disposition",
            "path": "EnrollmentResponse.disposition",
            "short": "Disposition Message",
            "definition": "A description of the status of the adjudication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "EnrollmentResponse.created",
            "path": "EnrollmentResponse.created",
            "short": "Creation date",
            "definition": "The date when the enclosed suite of services were performed or completed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "EnrollmentResponse.organization",
            "path": "EnrollmentResponse.organization",
            "short": "Insurer",
            "definition": "The Insurer who produced this adjudicated response.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "EnrollmentResponse.requestProvider",
            "path": "EnrollmentResponse.requestProvider",
            "short": "Responsible practitioner",
            "definition": "The practitioner who is responsible for the services rendered to the patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'EnrollmentResponse'
    /// </summary>
    // 0. EnrollmentResponse
    public partial class Resource_EnrollmentResponse : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. EnrollmentResponse.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. EnrollmentResponse.status
        public ElementDefinitionInfo Element_Status;
        // 3. EnrollmentResponse.request
        public ElementDefinitionInfo Element_Request;
        // 4. EnrollmentResponse.outcome
        public ElementDefinitionInfo Element_Outcome;
        // 5. EnrollmentResponse.disposition
        public ElementDefinitionInfo Element_Disposition;
        // 6. EnrollmentResponse.created
        public ElementDefinitionInfo Element_Created;
        // 7. EnrollmentResponse.organization
        public ElementDefinitionInfo Element_Organization;
        // 8. EnrollmentResponse.requestProvider
        public ElementDefinitionInfo Element_RequestProvider;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "EnrollmentResponse",
                ElementId = "EnrollmentResponse"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Request.Write(sDef);
            Element_Outcome.Write(sDef);
            Element_Disposition.Write(sDef);
            Element_Created.Write(sDef);
            Element_Organization.Write(sDef);
            Element_RequestProvider.Write(sDef);
        }
        
        public Resource_EnrollmentResponse()
        {
            {
                // 1. EnrollmentResponse.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "EnrollmentResponse.identifier",
                    Id = "EnrollmentResponse.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. EnrollmentResponse.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "EnrollmentResponse.status",
                    Id = "EnrollmentResponse.status",
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
                // 3. EnrollmentResponse.request
                this.Element_Request = new ElementDefinitionInfo
                {
                    Name = "Element_Request",
                    Path= "EnrollmentResponse.request",
                    Id = "EnrollmentResponse.request",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/EnrollmentRequest"
                            }
                        }
                    }
                };
            }
            {
                // 4. EnrollmentResponse.outcome
                this.Element_Outcome = new ElementDefinitionInfo
                {
                    Name = "Element_Outcome",
                    Path= "EnrollmentResponse.outcome",
                    Id = "EnrollmentResponse.outcome",
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
                // 5. EnrollmentResponse.disposition
                this.Element_Disposition = new ElementDefinitionInfo
                {
                    Name = "Element_Disposition",
                    Path= "EnrollmentResponse.disposition",
                    Id = "EnrollmentResponse.disposition",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 6. EnrollmentResponse.created
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "EnrollmentResponse.created",
                    Id = "EnrollmentResponse.created",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 7. EnrollmentResponse.organization
                this.Element_Organization = new ElementDefinitionInfo
                {
                    Name = "Element_Organization",
                    Path= "EnrollmentResponse.organization",
                    Id = "EnrollmentResponse.organization",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 8. EnrollmentResponse.requestProvider
                this.Element_RequestProvider = new ElementDefinitionInfo
                {
                    Name = "Element_RequestProvider",
                    Path= "EnrollmentResponse.requestProvider",
                    Id = "EnrollmentResponse.requestProvider",
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
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            this.Name = "EnrollmentResponse";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/EnrollmentResponse";
        }
    }
}
