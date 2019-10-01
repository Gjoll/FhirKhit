using System;                                                                                                                               // MakerGen.cs:497
using System.Diagnostics;                                                                                                                   // MakerGen.cs:498
using System.IO;                                                                                                                            // MakerGen.cs:499
using System.Linq;                                                                                                                          // MakerGen.cs:500
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:501
                                                                                                                                            // MakerGen.cs:502
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:503
{                                                                                                                                           // MakerGen.cs:504
    #region Json                                                                                                                            // MakerGen.cs:505
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
    #endregion                                                                                                                              // MakerGen.cs:509
    /// <summary>
    /// Fhir complex 'ContactDetail'
    /// </summary>
    // 0. ContactDetail
    public class ContactDetail : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class ContactDetail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. ContactDetail.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 2. ContactDetail.telecom
            public ElementDefinitionInfo Telecom;                                                                                           // MakerGen.cs:216
            public ContactDetail_Elements()                                                                                                 // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. ContactDetail.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "ContactDetail.name",                                                                                         // MakerGen.cs:236
                        Id = "ContactDetail.name",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. ContactDetail.telecom
                    this.Telecom = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Telecom",                                                                                                   // MakerGen.cs:235
                        Path= "ContactDetail.telecom",                                                                                      // MakerGen.cs:236
                        Id = "ContactDetail.telecom",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Telecom.Write(sDef);                                                                                                        // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public ContactDetail_Elements Elements { get; }                                                                                     // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public ContactDetail()                                                                                                              // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new ContactDetail_Elements();                                                                                   // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:514
