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
      "id": "Parameters",
      "url": "http://hl7.org/fhir/StructureDefinition/Parameters",
      "version": "4.0.0",
      "name": "Parameters",
      "status": "active",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "This resource is a non-persisted resource used to pass information into and back from an [operation](operations.html). It has no other use, and there is no RESTful endpoint associated with it.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Parameters",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Resource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Parameters",
            "path": "Parameters",
            "short": "Operation Request or Response",
            "definition": "This resource is a non-persisted resource used to pass information into and back from an [operation](operations.html). It has no other use, and there is no RESTful endpoint associated with it.",
            "comment": "The parameters that may be used are defined by the OperationDefinition resource.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Parameters.parameter",
            "path": "Parameters.parameter",
            "short": "Operation Parameter",
            "definition": "A parameter passed to or received from the operation.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Parameters.parameter.name",
            "path": "Parameters.parameter.name",
            "short": "Name from the definition",
            "definition": "The name of the parameter (reference to the operation definition).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Parameters.parameter.value[x]",
            "path": "Parameters.parameter.value[x]",
            "short": "If parameter is a data type",
            "definition": "If the parameter is a data type.",
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
            ],
            "condition": [
              "inv-1"
            ],
            "isSummary": true
          },
          {
            "id": "Parameters.parameter.resource",
            "path": "Parameters.parameter.resource",
            "short": "If parameter is a whole resource",
            "definition": "If the parameter is a whole resource.",
            "comment": "When resolving references in resources, the operation definition may specify how references may be resolved between parameters. If a reference cannot be resolved between the parameters, the application should fall back to it's general resource resolution methods.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Resource"
              }
            ],
            "condition": [
              "inv-1"
            ],
            "isSummary": true
          },
          {
            "id": "Parameters.parameter.part",
            "path": "Parameters.parameter.part",
            "short": "Named part of a multi-part parameter",
            "definition": "A named part of a multi-part parameter.",
            "comment": "Only one level of nested parameters is allowed.",
            "min": 0,
            "max": "*",
            "contentReference": "#Parameters.parameter",
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Parameters'
    /// </summary>
    // 0. Parameters
    public partial class Resource_Parameters : FhirKhit.Maker.Common.Resource.Resource_Resource
    {
        // 1. Parameters.parameter
        public partial class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 2. Parameters.parameter.name
            public ElementDefinitionInfo Element_Name;
            // 3. Parameters.parameter.value[x]
            public ElementDefinitionInfo Element_Value;
            // 4. Parameters.parameter.resource
            public ElementDefinitionInfo Element_Resource;
            // 5. Parameters.parameter.part
            public ElementDefinitionInfo Element_Part;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Parameters.parameter",
                    ElementId = "Parameters.parameter"
                });
                Element_Name.Write(sDef);
                Element_Value.Write(sDef);
                Element_Resource.Write(sDef);
                Element_Part.Write(sDef);
            }
            
            public Type_Parameter()
            {
                {
                    // 2. Parameters.parameter.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "Parameters.parameter.name",
                        Id = "Parameters.parameter.name",
                        Min = 1,
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
                    // 3. Parameters.parameter.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "Parameters.parameter.value[x]",
                        Id = "Parameters.parameter.value[x]",
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
                {
                    // 4. Parameters.parameter.resource
                    this.Element_Resource = new ElementDefinitionInfo
                    {
                        Name = "Element_Resource",
                        Path= "Parameters.parameter.resource",
                        Id = "Parameters.parameter.resource",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Resource.Resource_Resource
                            {
                            }
                        }
                    };
                }
                {
                    // 5. Parameters.parameter.part
                    this.Element_Part = new ElementDefinitionInfo
                    {
                        Name = "Element_Part",
                        Path= "Parameters.parameter.part",
                        Id = "Parameters.parameter.part",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. Parameters.parameter
        public ElementDefinitionInfo Element_Parameter;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Parameters",
                ElementId = "Parameters"
            });
            Element_Parameter.Write(sDef);
        }
        
        public Resource_Parameters()
        {
            {
                // 1. Parameters.parameter
                this.Element_Parameter = new ElementDefinitionInfo
                {
                    Name = "Element_Parameter",
                    Path= "Parameters.parameter",
                    Id = "Parameters.parameter",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Parameter
                        {
                        }
                    }
                };
            }
            this.Name = "Parameters";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Parameters";
        }
    }
}
