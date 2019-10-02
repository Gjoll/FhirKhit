using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
    {
      "resourceType": "StructureDefinition",
      "id": "SupplyRequest",
      "url": "http://hl7.org/fhir/StructureDefinition/SupplyRequest",
      "version": "4.0.0",
      "name": "SupplyRequest",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A record of a request for a medication, substance or device used in the healthcare setting.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SupplyRequest",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SupplyRequest",
            "path": "SupplyRequest",
            "short": "Request for a medication, substance or device",
            "definition": "A record of a request for a medication, substance or device used in the healthcare setting.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SupplyRequest.identifier",
            "path": "SupplyRequest.identifier",
            "short": "Business Identifier for SupplyRequest",
            "definition": "Business identifiers assigned to this SupplyRequest by the author and/or other systems. These identifiers remain constant as the resource is updated and propagates from server to server.",
            "comment": "The identifier.type element is used to distinguish between the identifiers assigned by the requester/placer and the performer/filler.",
            "requirements": "Allows identification of the request as it is known by various participating systems and in a way that remains consistent across servers.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyRequest.status",
            "path": "SupplyRequest.status",
            "short": "draft | active | suspended +",
            "definition": "Status of the supply request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SupplyRequestStatus"
                }
              ],
              "strength": "required",
              "description": "Status of the supply request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supplyrequest-status|4.0.0"
            }
          },
          {
            "id": "SupplyRequest.category",
            "path": "SupplyRequest.category",
            "short": "The kind of supply (central, non-stock, etc.)",
            "definition": "Category of supply, e.g.  central, non-stock, etc. This is used to support work flows associated with the supply process.",
            "alias": [
              "kind"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SupplyRequestKind"
                }
              ],
              "strength": "example",
              "description": "Category of supply request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supplyrequest-kind"
            }
          },
          {
            "id": "SupplyRequest.priority",
            "path": "SupplyRequest.priority",
            "short": "routine | urgent | asap | stat",
            "definition": "Indicates how quickly this SupplyRequest should be addressed with respect to other requests.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "meaningWhenMissing": "If missing, this task should be performed with normal priority",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "RequestPriority"
                }
              ],
              "strength": "required",
              "description": "Identifies the level of importance to be assigned to actioning the request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "SupplyRequest.item[x]",
            "path": "SupplyRequest.item[x]",
            "short": "Medication, Substance, or Device requested to be supplied",
            "definition": "The item that is requested to be supplied. This is either a link to a resource representing the details of the item or a code that identifies the item from a known list.",
            "comment": "Note that there's a difference between a prescription - an instruction to take a medication, along with a (sometimes) implicit supply, and an explicit request to supply, with no explicit instructions.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SupplyRequestItem"
                }
              ],
              "strength": "example",
              "description": "The item that was requested.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supply-item"
            }
          },
          {
            "id": "SupplyRequest.quantity",
            "path": "SupplyRequest.quantity",
            "short": "The requested amount of the item indicated",
            "definition": "The amount that is being ordered of the indicated item.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyRequest.parameter",
            "path": "SupplyRequest.parameter",
            "short": "Ordered item details",
            "definition": "Specific parameters for the ordered item.  For example, the size of the indicated item.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "SupplyRequest.parameter.code",
            "path": "SupplyRequest.parameter.code",
            "short": "Item detail",
            "definition": "A code or string that identifies the device detail being asserted.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ParameterCode"
                }
              ],
              "strength": "example",
              "description": "A code that identifies the device detail."
            }
          },
          {
            "id": "SupplyRequest.parameter.value[x]",
            "path": "SupplyRequest.parameter.value[x]",
            "short": "Value of detail",
            "definition": "The value of the device detail.",
            "comment": "Range means device should have a value that falls somewhere within the specified range.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "SupplyRequest.occurrence[x]",
            "path": "SupplyRequest.occurrence[x]",
            "short": "When the request should be fulfilled",
            "definition": "When the request should be fulfilled.",
            "alias": [
              "when",
              "timing"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              },
              {
                "code": "Timing"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyRequest.authoredOn",
            "path": "SupplyRequest.authoredOn",
            "short": "When the request was made",
            "definition": "When the request was made.",
            "alias": [
              "date",
              "createdOn",
              "signedOn"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyRequest.requester",
            "path": "SupplyRequest.requester",
            "short": "Individual making the request",
            "definition": "The device, practitioner, etc. who initiated the request.",
            "alias": [
              "author",
              "source"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyRequest.supplier",
            "path": "SupplyRequest.supplier",
            "short": "Who is intended to fulfill the request",
            "definition": "Who is intended to fulfill the request.",
            "alias": [
              "performer"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SupplyRequest.reasonCode",
            "path": "SupplyRequest.reasonCode",
            "short": "The reason why the supply item was requested",
            "definition": "The reason why the supply item was requested.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SupplyRequestReason"
                }
              ],
              "strength": "example",
              "description": "The reason why the supply item was requested.",
              "valueSet": "http://hl7.org/fhir/ValueSet/supplyrequest-reason"
            }
          },
          {
            "id": "SupplyRequest.reasonReference",
            "path": "SupplyRequest.reasonReference",
            "short": "The reason why the supply item was requested",
            "definition": "The reason why the supply item was requested.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ]
          },
          {
            "id": "SupplyRequest.deliverFrom",
            "path": "SupplyRequest.deliverFrom",
            "short": "The origin of the supply",
            "definition": "Where the supply is expected to come from.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "SupplyRequest.deliverTo",
            "path": "SupplyRequest.deliverTo",
            "short": "The destination of the supply",
            "definition": "Where the supply is destined to go.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'SupplyRequest'
    /// </summary>
    // 0. SupplyRequest
    public class Resource_SupplyRequest : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                            // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 7. SupplyRequest.parameter
        public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 8. SupplyRequest.parameter.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:219
            // 9. SupplyRequest.parameter.value[x]
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "SupplyRequest.parameter",                                                                                       // MakerGen.cs:395
                    ElementId = "SupplyRequest.parameter"                                                                                   // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Parameter()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 8. SupplyRequest.parameter.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Code",                                                                                              // MakerGen.cs:238
                        Path= "SupplyRequest.parameter.code",                                                                               // MakerGen.cs:239
                        Id = "SupplyRequest.parameter.code",                                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 9. SupplyRequest.parameter.value[x]
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Value",                                                                                             // MakerGen.cs:238
                        Path= "SupplyRequest.parameter.value[x]",                                                                           // MakerGen.cs:239
                        Id = "SupplyRequest.parameter.value[x]",                                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            },                                                                                                              // MakerGen.cs:322
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. SupplyRequest.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. SupplyRequest.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 3. SupplyRequest.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:219
        // 4. SupplyRequest.priority
        public ElementDefinitionInfo Element_Priority;                                                                                      // MakerGen.cs:219
        // 5. SupplyRequest.item[x]
        public ElementDefinitionInfo Element_Item;                                                                                          // MakerGen.cs:219
        // 6. SupplyRequest.quantity
        public ElementDefinitionInfo Element_Quantity;                                                                                      // MakerGen.cs:219
        // 7. SupplyRequest.parameter
        public ElementDefinitionInfo Element_Parameter;                                                                                     // MakerGen.cs:219
        // 10. SupplyRequest.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;                                                                                    // MakerGen.cs:219
        // 11. SupplyRequest.authoredOn
        public ElementDefinitionInfo Element_AuthoredOn;                                                                                    // MakerGen.cs:219
        // 12. SupplyRequest.requester
        public ElementDefinitionInfo Element_Requester;                                                                                     // MakerGen.cs:219
        // 13. SupplyRequest.supplier
        public ElementDefinitionInfo Element_Supplier;                                                                                      // MakerGen.cs:219
        // 14. SupplyRequest.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:219
        // 15. SupplyRequest.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;                                                                               // MakerGen.cs:219
        // 16. SupplyRequest.deliverFrom
        public ElementDefinitionInfo Element_DeliverFrom;                                                                                   // MakerGen.cs:219
        // 17. SupplyRequest.deliverTo
        public ElementDefinitionInfo Element_DeliverTo;                                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "SupplyRequest",                                                                                                     // MakerGen.cs:395
                ElementId = "SupplyRequest"                                                                                                 // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Priority.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Item.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Quantity.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Parameter.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Occurrence.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_AuthoredOn.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Requester.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Supplier.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_ReasonReference.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_DeliverFrom.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_DeliverTo.Write(sDef);                                                                                                  // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_SupplyRequest()                                                                                                     // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. SupplyRequest.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "SupplyRequest.identifier",                                                                                       // MakerGen.cs:239
                    Id = "SupplyRequest.identifier",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. SupplyRequest.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "SupplyRequest.status",                                                                                           // MakerGen.cs:239
                    Id = "SupplyRequest.status",                                                                                            // MakerGen.cs:240
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
                // 3. SupplyRequest.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Category",                                                                                              // MakerGen.cs:238
                    Path= "SupplyRequest.category",                                                                                         // MakerGen.cs:239
                    Id = "SupplyRequest.category",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. SupplyRequest.priority
                this.Element_Priority = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Priority",                                                                                              // MakerGen.cs:238
                    Path= "SupplyRequest.priority",                                                                                         // MakerGen.cs:239
                    Id = "SupplyRequest.priority",                                                                                          // MakerGen.cs:240
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
                // 5. SupplyRequest.item[x]
                this.Element_Item = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Item",                                                                                                  // MakerGen.cs:238
                    Path= "SupplyRequest.item[x]",                                                                                          // MakerGen.cs:239
                    Id = "SupplyRequest.item[x]",                                                                                           // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        },                                                                                                                  // MakerGen.cs:322
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Medication",                                                       // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Substance",                                                        // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. SupplyRequest.quantity
                this.Element_Quantity = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:238
                    Path= "SupplyRequest.quantity",                                                                                         // MakerGen.cs:239
                    Id = "SupplyRequest.quantity",                                                                                          // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. SupplyRequest.parameter
                this.Element_Parameter = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Parameter",                                                                                             // MakerGen.cs:238
                    Path= "SupplyRequest.parameter",                                                                                        // MakerGen.cs:239
                    Id = "SupplyRequest.parameter",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Parameter                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. SupplyRequest.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Occurrence",                                                                                            // MakerGen.cs:238
                    Path= "SupplyRequest.occurrence[x]",                                                                                    // MakerGen.cs:239
                    Id = "SupplyRequest.occurrence[x]",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        },                                                                                                                  // MakerGen.cs:307
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        },                                                                                                                  // MakerGen.cs:360
                        new FhirKhit.Maker.Common.Complex.Type_Timing                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. SupplyRequest.authoredOn
                this.Element_AuthoredOn = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AuthoredOn",                                                                                            // MakerGen.cs:238
                    Path= "SupplyRequest.authoredOn",                                                                                       // MakerGen.cs:239
                    Id = "SupplyRequest.authoredOn",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. SupplyRequest.requester
                this.Element_Requester = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Requester",                                                                                             // MakerGen.cs:238
                    Path= "SupplyRequest.requester",                                                                                        // MakerGen.cs:239
                    Id = "SupplyRequest.requester",                                                                                         // MakerGen.cs:240
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
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 13. SupplyRequest.supplier
                this.Element_Supplier = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Supplier",                                                                                              // MakerGen.cs:238
                    Path= "SupplyRequest.supplier",                                                                                         // MakerGen.cs:239
                    Id = "SupplyRequest.supplier",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService"                                                 // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 14. SupplyRequest.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:238
                    Path= "SupplyRequest.reasonCode",                                                                                       // MakerGen.cs:239
                    Id = "SupplyRequest.reasonCode",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 15. SupplyRequest.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:238
                    Path= "SupplyRequest.reasonReference",                                                                                  // MakerGen.cs:239
                    Id = "SupplyRequest.reasonReference",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition",                                                        // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Observation",                                                      // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                                 // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 16. SupplyRequest.deliverFrom
                this.Element_DeliverFrom = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_DeliverFrom",                                                                                           // MakerGen.cs:238
                    Path= "SupplyRequest.deliverFrom",                                                                                      // MakerGen.cs:239
                    Id = "SupplyRequest.deliverFrom",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 17. SupplyRequest.deliverTo
                this.Element_DeliverTo = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_DeliverTo",                                                                                             // MakerGen.cs:238
                    Path= "SupplyRequest.deliverTo",                                                                                        // MakerGen.cs:239
                    Id = "SupplyRequest.deliverTo",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Location",                                                         // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "SupplyRequest";                                                                                                    // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SupplyRequest";                                                             // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
