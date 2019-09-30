using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'Narrative'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Narrative",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Narrative",
    ///   "version": "4.0.0",
    ///   "name": "Narrative",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Narrative Type: A human-readable summary of the resource conveying the essential clinical and business information for the resource.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Narrative",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Narrative",
    ///         "extension": [
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status",
    ///             "valueCode": "normative"
    ///           },
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-normative-version",
    ///             "valueCode": "4.0.0"
    ///           }
    ///         ],
    ///         "path": "Narrative",
    ///         "short": "Human-readable summary of the resource (essential clinical and business information)",
    ///         "definition": "A human-readable summary of the resource conveying the essential clinical and business information for the resource.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Narrative.status",
    ///         "path": "Narrative.status",
    ///         "short": "generated | extensions | additional | empty",
    ///         "definition": "The status of the narrative - whether it's entirely generated (from just the defined data or the extensions too), or whether a human authored it and it may contain additional data.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "NarrativeStatus"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "The status of a resource narrative.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/narrative-status|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "Narrative.div",
    ///         "path": "Narrative.div",
    ///         "short": "Limited xhtml content",
    ///         "definition": "The actual narrative content, a stripped down version of XHTML.",
    ///         "comment": "The contents of the html element are an XHTML fragment containing only the basic html formatting elements described in chapters 7-11 and 15 of the HTML 4.0 standard, <a> elements (either name or href), images and internally contained stylesheets. The XHTML content SHALL NOT contain a head, a body, external stylesheet references, scripts, forms, base/link/xlink, frames, iframes and objects.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "xhtml"
    ///           }
    ///         ],
    ///         "constraint": [
    ///           {
    ///             "key": "txt-1",
    ///             "severity": "error",
    ///             "human": "The narrative SHALL contain only the basic html formatting elements and attributes described in chapters 7-11 (except section 4 of chapter 9) and 15 of the HTML 4.0 standard, <a> elements (either name or href), images and internally contained style attributes",
    ///             "expression": "htmlChecks()",
    ///             "xpath": "not(descendant-or-self::*[not(local-name(.)=('a', 'abbr', 'acronym', 'b', 'big', 'blockquote', 'br', 'caption', 'cite', 'code', 'col', 'colgroup', 'dd', 'dfn', 'div', 'dl', 'dt', 'em', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'hr', 'i', 'img', 'li', 'ol', 'p', 'pre', 'q', 'samp', 'small', 'span', 'strong', 'sub', 'sup', 'table', 'tbody', 'td', 'tfoot', 'th', 'thead', 'tr', 'tt', 'ul', 'var'))]) and not(descendant-or-self::*/@*[not(name(.)=('abbr', 'accesskey', 'align', 'alt', 'axis', 'bgcolor', 'border', 'cellhalign', 'cellpadding', 'cellspacing', 'cellvalign', 'char', 'charoff', 'charset', 'cite', 'class', 'colspan', 'compact', 'coords', 'dir', 'frame', 'headers', 'height', 'href', 'hreflang', 'hspace', 'id', 'lang', 'longdesc', 'name', 'nowrap', 'rel', 'rev', 'rowspan', 'rules', 'scope', 'shape', 'span', 'src', 'start', 'style', 'summary', 'tabindex', 'title', 'type', 'valign', 'value', 'vspace', 'width'))])"
    ///           },
    ///           {
    ///             "key": "txt-2",
    ///             "severity": "error",
    ///             "human": "The narrative SHALL have some non-whitespace content",
    ///             "expression": "htmlChecks()",
    ///             "xpath": "descendant::text()[normalize-space(.)!=''] or descendant::h:img[@src]"
    ///           }
    ///         ]
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Narrative_Type : Complex_Type
    {
    }
}
