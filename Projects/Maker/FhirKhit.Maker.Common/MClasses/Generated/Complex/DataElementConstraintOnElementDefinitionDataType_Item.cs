using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'DataElement constraint on ElementDefinition data type'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "elementdefinition-de",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-de",
    ///   "version": "4.0.0",
    ///   "name": "DataElement constraint on ElementDefinition data type",
    ///   "status": "draft",
    ///   "experimental": false,
    ///   "publisher": "Health Level Seven International (Orders and Observations)",
    ///   "description": "Identifies how the ElementDefinition data type is used when it appears within a data element",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "ElementDefinition",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/ElementDefinition",
    ///   "derivation": "constraint",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "ElementDefinition",
    ///         "path": "ElementDefinition",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.extension:Question",
    ///         "path": "ElementDefinition.extension",
    ///         "sliceName": "Question",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Extension",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/elementdefinition-question"
    ///             ]
    ///           }
    ///         ]
    ///       },
    ///       {
    ///         "id": "ElementDefinition.extension:AllowedUnits",
    ///         "path": "ElementDefinition.extension",
    ///         "sliceName": "AllowedUnits",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Extension",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/elementdefinition-allowedUnits"
    ///             ]
    ///           }
    ///         ]
    ///       },
    ///       {
    ///         "id": "ElementDefinition.representation",
    ///         "path": "ElementDefinition.representation",
    ///         "min": 0,
    ///         "max": "0"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.slicing",
    ///         "path": "ElementDefinition.slicing",
    ///         "min": 0,
    ///         "max": "0"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.short",
    ///         "path": "ElementDefinition.short",
    ///         "min": 0,
    ///         "max": "0"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.contentReference",
    ///         "path": "ElementDefinition.contentReference",
    ///         "min": 0,
    ///         "max": "0"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.type",
    ///         "path": "ElementDefinition.type"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.type.profile",
    ///         "path": "ElementDefinition.type.profile",
    ///         "min": 0,
    ///         "max": "0"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.type.aggregation",
    ///         "path": "ElementDefinition.type.aggregation",
    ///         "min": 0,
    ///         "max": "0"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.defaultValue[x]",
    ///         "path": "ElementDefinition.defaultValue[x]",
    ///         "comment": "...  This element should only be used on child elements of complex data elements."
    ///       },
    ///       {
    ///         "id": "ElementDefinition.meaningWhenMissing",
    ///         "path": "ElementDefinition.meaningWhenMissing",
    ///         "comment": "...  This element should only be used on child elements of complex data elements."
    ///       },
    ///       {
    ///         "id": "ElementDefinition.fixed[x]",
    ///         "path": "ElementDefinition.fixed[x]",
    ///         "min": 0,
    ///         "max": "0"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.pattern[x]",
    ///         "path": "ElementDefinition.pattern[x]",
    ///         "min": 0,
    ///         "max": "0"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.isModifier",
    ///         "path": "ElementDefinition.isModifier",
    ///         "min": 0,
    ///         "max": "0"
    ///       },
    ///       {
    ///         "id": "ElementDefinition.isSummary",
    ///         "path": "ElementDefinition.isSummary",
    ///         "min": 0,
    ///         "max": "0"
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class DataElementConstraintOnElementDefinitionDataType_Item : Complex_Item
    {
    }
}
