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
      "id": "Extension",
      "url": "http://hl7.org/fhir/StructureDefinition/Extension",
      "version": "4.0.0",
      "name": "Extension",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Extension Type: Optional Extension Element - found in all resources.",
      "purpose": "The ability to add extensions in a structured way is what keeps FHIR resources simple.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Extension",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Extension",
            "path": "Extension",
            "short": "Optional Extensions Element",
            "definition": "Optional Extension Element - found in all resources.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Extension.url",
            "path": "Extension.url",
            "representation": [
              "xmlAttr"
            ],
            "short": "identifies the meaning of the extension",
            "definition": "Source of the definition for the extension code - a logical name or a URL.",
            "comment": "The definition may point directly to a computable or human-readable definition of the extensibility codes, or it may be a logical URI as declared in some other specification. The definition SHALL be a URI for the Structure Definition defining the extension.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "_code": {
                  "extension": [
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-json-type",
                      "valueString": "string"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-xml-type",
                      "valueString": "xsd:string"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:string"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/regex",
                      "valueString": "((http|https)://([A-Za-z0-9\\\\\\.\\:\\%\\$]*\\/)*)?(Account|ActivityDefinition|AdverseEvent|AllergyIntolerance|Appointment|AppointmentResponse|AuditEvent|Basic|Binary|BiologicallyDerivedProduct|BodyStructure|Bundle|CapabilityStatement|CarePlan|CareTeam|CatalogEntry|ChargeItem|ChargeItemDefinition|Claim|ClaimResponse|ClinicalImpression|CodeSystem|Communication|CommunicationRequest|CompartmentDefinition|Composition|ConceptMap|Condition|Consent|Contract|Coverage|CoverageEligibilityRequest|CoverageEligibilityResponse|DetectedIssue|Device|DeviceDefinition|DeviceMetric|DeviceRequest|DeviceUseStatement|DiagnosticReport|DocumentManifest|DocumentReference|EffectEvidenceSynthesis|Encounter|Endpoint|EnrollmentRequest|EnrollmentResponse|EpisodeOfCare|EventDefinition|Evidence|EvidenceVariable|ExampleScenario|ExplanationOfBenefit|FamilyMemberHistory|Flag|Goal|GraphDefinition|Group|GuidanceResponse|HealthcareService|ImagingStudy|Immunization|ImmunizationEvaluation|ImmunizationRecommendation|ImplementationGuide|InsurancePlan|Invoice|Library|Linkage|List|Location|Measure|MeasureReport|Media|Medication|MedicationAdministration|MedicationDispense|MedicationKnowledge|MedicationRequest|MedicationStatement|MedicinalProduct|MedicinalProductAuthorization|MedicinalProductContraindication|MedicinalProductIndication|MedicinalProductIngredient|MedicinalProductInteraction|MedicinalProductManufactured|MedicinalProductPackaged|MedicinalProductPharmaceutical|MedicinalProductUndesirableEffect|MessageDefinition|MessageHeader|MolecularSequence|NamingSystem|NutritionOrder|Observation|ObservationDefinition|OperationDefinition|OperationOutcome|Organization|OrganizationAffiliation|Patient|PaymentNotice|PaymentReconciliation|Person|PlanDefinition|Practitioner|PractitionerRole|Procedure|Provenance|Questionnaire|QuestionnaireResponse|RelatedPerson|RequestGroup|ResearchDefinition|ResearchElementDefinition|ResearchStudy|ResearchSubject|RiskAssessment|RiskEvidenceSynthesis|Schedule|SearchParameter|ServiceRequest|Slot|Specimen|SpecimenDefinition|StructureDefinition|StructureMap|Subscription|Substance|SubstanceNucleicAcid|SubstancePolymer|SubstanceProtein|SubstanceReferenceInformation|SubstanceSourceMaterial|SubstanceSpecification|SupplyDelivery|SupplyRequest|Task|TerminologyCapabilities|TestReport|TestScript|ValueSet|VerificationResult|VisionPrescription)\\/[A-Za-z0-9\\-\\.]{1,64}(\\/_history\\/[A-Za-z0-9\\-\\.]{1,64})?"
                    }
                  ]
                }
              }
            ]
          },
          {
            "id": "Extension.value[x]",
            "path": "Extension.value[x]",
            "short": "Value of extension",
            "definition": "Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "base64Binary"
              },
              {
                "code": "boolean"
              },
              {
                "code": "canonical"
              },
              {
                "code": "code"
              },
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "decimal"
              },
              {
                "code": "id"
              },
              {
                "code": "instant"
              },
              {
                "code": "integer"
              },
              {
                "code": "markdown"
              },
              {
                "code": "oid"
              },
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              },
              {
                "code": "time"
              },
              {
                "code": "unsignedInt"
              },
              {
                "code": "uri"
              },
              {
                "code": "url"
              },
              {
                "code": "uuid"
              },
              {
                "code": "Address"
              },
              {
                "code": "Age"
              },
              {
                "code": "Annotation"
              },
              {
                "code": "Attachment"
              },
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Coding"
              },
              {
                "code": "ContactPoint"
              },
              {
                "code": "Count"
              },
              {
                "code": "Distance"
              },
              {
                "code": "Duration"
              },
              {
                "code": "HumanName"
              },
              {
                "code": "Identifier"
              },
              {
                "code": "Money"
              },
              {
                "code": "Period"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "Ratio"
              },
              {
                "code": "Reference"
              },
              {
                "code": "SampledData"
              },
              {
                "code": "Signature"
              },
              {
                "code": "Timing"
              },
              {
                "code": "ContactDetail"
              },
              {
                "code": "Contributor"
              },
              {
                "code": "DataRequirement"
              },
              {
                "code": "Expression"
              },
              {
                "code": "ParameterDefinition"
              },
              {
                "code": "RelatedArtifact"
              },
              {
                "code": "TriggerDefinition"
              },
              {
                "code": "UsageContext"
              },
              {
                "code": "Dosage"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir complex 'Extension'
    /// </summary>
    // 0. Extension
    public partial class Type_Extension : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. Extension.url
        public ElementDefinitionInfo Element_Url;
        // 2. Extension.value[x]
        public ElementDefinitionInfo Element_Value;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Extension",
                ElementId = "Extension"
            });
            Element_Url.Write(sDef);
            Element_Value.Write(sDef);
        }
        
        public Type_Extension()
        {
            {
                // 1. Extension.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "Extension.url",
                    Id = "Extension.url",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                    }
                };
            }
            {
                // 2. Extension.value[x]
                this.Element_Value = new ElementDefinitionInfo
                {
                    Name = "Element_Value",
                    Path= "Extension.value[x]",
                    Id = "Extension.value[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Id
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Oid
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Time
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Url
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uuid
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Address
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Age
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Attachment
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Coding
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Count
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Distance
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Duration
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_HumanName
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Money
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Range
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Ratio
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_SampledData
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Signature
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Timing
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Contributor
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_DataRequirement
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Expression
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_ParameterDefinition
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_RelatedArtifact
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_TriggerDefinition
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Dosage
                        {
                        }
                    }
                };
            }
        }
    }
}
