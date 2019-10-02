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
      "id": "ContactDetail",
      "url": "http://hl7.org/fhir/StructureDefinition/ContactDetail",
      "version": "4.0.0",
      "name": "ContactDetail",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for ContactDetail Type: Specifies contact information for a person or organization.",
      "purpose": "Need to track contact information in the same way across multiple resources.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "ContactDetail",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ContactDetail",
            "path": "ContactDetail",
            "short": "Contact information",
            "definition": "Specifies contact information for a person or organization.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ContactDetail.name",
            "path": "ContactDetail.name",
            "short": "Name of an individual to contact",
            "definition": "The name of an individual to contact.",
            "comment": "If there is no named individual, the telecom information is for the organization as a whole.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ContactDetail.telecom",
            "path": "ContactDetail.telecom",
            "short": "Contact details for individual or organization",
            "definition": "The contact details for the individual (if a name was provided) or the organization.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir complex 'ContactDetail'
    /// </summary>
    // 0. ContactDetail
    public class Type_ContactDetail : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. ContactDetail.name
        public ElementDefinitionInfo Element_Name;
        // 2. ContactDetail.telecom
        public ElementDefinitionInfo Element_Telecom;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ContactDetail",
                ElementId = "ContactDetail"
            });
            Element_Name.Write(sDef);
            Element_Telecom.Write(sDef);
        }
        
        public Type_ContactDetail()
        {
            {
                // 1. ContactDetail.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "ContactDetail.name",
                    Id = "ContactDetail.name",
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
                // 2. ContactDetail.telecom
                this.Element_Telecom = new ElementDefinitionInfo
                {
                    Name = "Element_Telecom",
                    Path= "ContactDetail.telecom",
                    Id = "ContactDetail.telecom",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                        {
                        }
                    }
                };
            }
        }
    }
}
