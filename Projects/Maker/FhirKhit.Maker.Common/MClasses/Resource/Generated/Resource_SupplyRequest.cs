using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'SupplyRequest'
    /// </summary>
    // 0. SupplyRequest
    public class Resource_SupplyRequest : FhirKhit.Maker.Common.Resource.ResourceBase                                                       // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 7. SupplyRequest.parameter
        public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 8. SupplyRequest.parameter.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:212
            // 9. SupplyRequest.parameter.value[x]
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SupplyRequest.parameter",                                                                                       // MakerGen.cs:388
                    ElementId = "SupplyRequest.parameter"                                                                                   // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Parameter()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 8. SupplyRequest.parameter.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Code",                                                                                              // MakerGen.cs:231
                        Path= "SupplyRequest.parameter.code",                                                                               // MakerGen.cs:232
                        Id = "SupplyRequest.parameter.code",                                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 9. SupplyRequest.parameter.value[x]
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Value",                                                                                             // MakerGen.cs:231
                        Path= "SupplyRequest.parameter.value[x]",                                                                           // MakerGen.cs:232
                        Id = "SupplyRequest.parameter.value[x]",                                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            },                                                                                                              // MakerGen.cs:315
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. SupplyRequest.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. SupplyRequest.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. SupplyRequest.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:212
        // 4. SupplyRequest.priority
        public ElementDefinitionInfo Element_Priority;                                                                                      // MakerGen.cs:212
        // 5. SupplyRequest.item[x]
        public ElementDefinitionInfo Element_Item;                                                                                          // MakerGen.cs:212
        // 6. SupplyRequest.quantity
        public ElementDefinitionInfo Element_Quantity;                                                                                      // MakerGen.cs:212
        // 7. SupplyRequest.parameter
        public ElementDefinitionInfo Element_Parameter;                                                                                     // MakerGen.cs:212
        // 10. SupplyRequest.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;                                                                                    // MakerGen.cs:212
        // 11. SupplyRequest.authoredOn
        public ElementDefinitionInfo Element_AuthoredOn;                                                                                    // MakerGen.cs:212
        // 12. SupplyRequest.requester
        public ElementDefinitionInfo Element_Requester;                                                                                     // MakerGen.cs:212
        // 13. SupplyRequest.supplier
        public ElementDefinitionInfo Element_Supplier;                                                                                      // MakerGen.cs:212
        // 14. SupplyRequest.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:212
        // 15. SupplyRequest.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;                                                                               // MakerGen.cs:212
        // 16. SupplyRequest.deliverFrom
        public ElementDefinitionInfo Element_DeliverFrom;                                                                                   // MakerGen.cs:212
        // 17. SupplyRequest.deliverTo
        public ElementDefinitionInfo Element_DeliverTo;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "SupplyRequest",                                                                                                     // MakerGen.cs:388
                ElementId = "SupplyRequest"                                                                                                 // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Priority.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Item.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Quantity.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Parameter.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Occurrence.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_AuthoredOn.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Requester.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Supplier.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_ReasonReference.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_DeliverFrom.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_DeliverTo.Write(sDef);                                                                                                  // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_SupplyRequest()                                                                                                     // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. SupplyRequest.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "SupplyRequest.identifier",                                                                                       // MakerGen.cs:232
                    Id = "SupplyRequest.identifier",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. SupplyRequest.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "SupplyRequest.status",                                                                                           // MakerGen.cs:232
                    Id = "SupplyRequest.status",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. SupplyRequest.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Category",                                                                                              // MakerGen.cs:231
                    Path= "SupplyRequest.category",                                                                                         // MakerGen.cs:232
                    Id = "SupplyRequest.category",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. SupplyRequest.priority
                this.Element_Priority = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Priority",                                                                                              // MakerGen.cs:231
                    Path= "SupplyRequest.priority",                                                                                         // MakerGen.cs:232
                    Id = "SupplyRequest.priority",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. SupplyRequest.item[x]
                this.Element_Item = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Item",                                                                                                  // MakerGen.cs:231
                    Path= "SupplyRequest.item[x]",                                                                                          // MakerGen.cs:232
                    Id = "SupplyRequest.item[x]",                                                                                           // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        },                                                                                                                  // MakerGen.cs:315
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Medication",                                                       // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Substance",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. SupplyRequest.quantity
                this.Element_Quantity = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:231
                    Path= "SupplyRequest.quantity",                                                                                         // MakerGen.cs:232
                    Id = "SupplyRequest.quantity",                                                                                          // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. SupplyRequest.parameter
                this.Element_Parameter = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Parameter",                                                                                             // MakerGen.cs:231
                    Path= "SupplyRequest.parameter",                                                                                        // MakerGen.cs:232
                    Id = "SupplyRequest.parameter",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Parameter                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. SupplyRequest.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Occurrence",                                                                                            // MakerGen.cs:231
                    Path= "SupplyRequest.occurrence[x]",                                                                                    // MakerGen.cs:232
                    Id = "SupplyRequest.occurrence[x]",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        },                                                                                                                  // MakerGen.cs:300
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Complex.Type_Timing                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. SupplyRequest.authoredOn
                this.Element_AuthoredOn = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_AuthoredOn",                                                                                            // MakerGen.cs:231
                    Path= "SupplyRequest.authoredOn",                                                                                       // MakerGen.cs:232
                    Id = "SupplyRequest.authoredOn",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. SupplyRequest.requester
                this.Element_Requester = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Requester",                                                                                             // MakerGen.cs:231
                    Path= "SupplyRequest.requester",                                                                                        // MakerGen.cs:232
                    Id = "SupplyRequest.requester",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. SupplyRequest.supplier
                this.Element_Supplier = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Supplier",                                                                                              // MakerGen.cs:231
                    Path= "SupplyRequest.supplier",                                                                                         // MakerGen.cs:232
                    Id = "SupplyRequest.supplier",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService"                                                 // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 14. SupplyRequest.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:231
                    Path= "SupplyRequest.reasonCode",                                                                                       // MakerGen.cs:232
                    Id = "SupplyRequest.reasonCode",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. SupplyRequest.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:231
                    Path= "SupplyRequest.reasonReference",                                                                                  // MakerGen.cs:232
                    Id = "SupplyRequest.reasonReference",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Observation",                                                      // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                                 // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. SupplyRequest.deliverFrom
                this.Element_DeliverFrom = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DeliverFrom",                                                                                           // MakerGen.cs:231
                    Path= "SupplyRequest.deliverFrom",                                                                                      // MakerGen.cs:232
                    Id = "SupplyRequest.deliverFrom",                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. SupplyRequest.deliverTo
                this.Element_DeliverTo = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DeliverTo",                                                                                             // MakerGen.cs:231
                    Path= "SupplyRequest.deliverTo",                                                                                        // MakerGen.cs:232
                    Id = "SupplyRequest.deliverTo",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Location",                                                         // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "SupplyRequest";                                                                                                    // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SupplyRequest";                                                             // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
