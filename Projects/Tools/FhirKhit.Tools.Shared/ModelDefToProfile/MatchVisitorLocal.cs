using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using FhirKhit.Tools.AntlrSupport;
using FhirKhit.Tools.MatchGrammar;
using FhirKhit.Tools.ModelDef.MatchGrammar.Antlr;
using Hl7.Fhir.Model;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// ANTLR Visitor class.
    /// </summary>
    public class MatchVisitorLocal : match_parserBaseVisitor<Object>
    {
        private readonly ElementDefinition source;
        private readonly ElementDefinition target;

        /// <summary>
        /// Constructor.
        /// </summary>
        public MatchVisitorLocal(ElementDefinition source,
            ElementDefinition target)
        {
            this.source = source;
            this.target = target;
        }

        void LTrace(String caller, String msg)
        {
            //Trace.WriteLine($"{caller}: {msg}");
            //Log.Trace(caller, msg);
        }

        String UnQuote(String s) => s.Substring(1, s.Length - 2);

        bool IsMemberOf(String value, StringPatternBase[] patterns)
        {
            value = value.ToUpper();
            foreach (StringPatternBase pattern in patterns)
            {
                if (pattern.IsMatch(value) == true)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Create a simple string pattern.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Object VisitMatch(match_parserParser.MatchContext context)
        {
            //# Tested
            return this.VisitOrDefault<Boolean>(context.boolRule());
        }

        /// <summary>
        /// Create a simple string pattern.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Object VisitStringPatternSimple(match_parserParser.StringPatternSimpleContext context)
        {
            //# Tested
            String patternText = this.VisitOrDefault<String>(context.stringValue());
            this.LTrace("MatchVisitorLocal.VisitStringPatternSimple", patternText);

            return new StringPatternSimple(patternText);
        }

        /// <summary>
        /// Create a open start string pattern.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Object VisitStringPatternOpenStart(match_parserParser.StringPatternOpenStartContext context)
        {
            //# Tested
            String patternText = this.VisitOrDefault<String>(context.stringValue());
            this.LTrace("MatchVisitorLocal.VisitStringPatternOpenStart", patternText);

            return new StringPatternOpenStart(patternText);
        }

        /// <summary>
        /// Create a open end string pattern.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Object VisitStringPatternOpenEnd(match_parserParser.StringPatternOpenEndContext context)
        {
            //# Tested
            String patternText = this.VisitOrDefault<String>(context.stringValue());
            this.LTrace("MatchVisitorLocal.VisitStringPatternOpenEnd", $"{patternText}");

            return new StringPatternOpenEnd(patternText);
        }

        /// <summary>
        /// Create a open string pattern.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Object VisitStringPatternOpen(match_parserParser.StringPatternOpenContext context)
        {
            //# Tested
            String patternText = this.VisitOrDefault<String>(context.stringValue());
            this.LTrace("MatchVisitorLocal.VisitStringPatternOpen", patternText);

            return new StringPatternOpen(patternText);
        }

        public override Object VisitStringArrayRegEx(match_parserParser.StringArrayRegExContext context)
        {
            //# Tested
            String regExText = this.VisitOrDefault<String>(context.stringValue());
            String[] lhsValues = this.VisitOrDefault<String[]>(context.stringArray());
            this.LTrace("MatchVisitorLocal.VisitStringArrayRegEx", $"{regExText} {lhsValues}");

            Regex regEx = new Regex(regExText.ToUpper(), RegexOptions.Singleline);
            foreach (String lhsValue in lhsValues)
            {
                Match match = regEx.Match(lhsValue.ToUpper());
                if (match.Success == false)
                    return false;
            }
            return true;
        }

        public override Object VisitStringValueRegEx(match_parserParser.StringValueRegExContext context)
        {
            //# Not Tested
            String[] patternText = this.VisitMultiple<String>(context.stringValue());
            this.LTrace("MatchVisitorLocal.VisitStringValueRegEx", $"{patternText}");

            Regex regEx = new Regex(patternText[1].ToUpper(), RegexOptions.Singleline);
            Match match = regEx.Match(patternText[0].ToUpper());
            return match.Success;
        }

        /// <summary>
        /// Creae a string pattern array from string and string arrays
        /// </summary>
        public override Object VisitStringPatternArray(match_parserParser.StringPatternArrayContext context)
        {
            //# Tested
            this.LTrace("MatchVisitorLocal.VisitStringPatternArray", "");
            List<StringPatternBase> retVal = new List<StringPatternBase>();
            {
                StringPatternBase[] values = this.VisitMultiple<StringPatternBase>(context.stringPattern());
                retVal.AddRange(values);
            }
            {
                String[][] values = this.VisitMultiple<String[]>(context.stringArray());
                foreach (String[] value1 in values)
                    foreach (String value2 in value1)
                        retVal.Add(new StringPatternSimple(value2));
            }

            return retVal.ToArray();
        }

        /// <summary>
        /// Return false
        /// </summary>
        public override Object VisitFalse(match_parserParser.FalseContext context) =>
            //# Tested
            false;

        /// <summary>
        /// Return false
        /// </summary>
        public override Object VisitTrue(match_parserParser.TrueContext context) =>
            //# Tested
            true;

        /// <summary>
        /// See if lhs string array is completely member of rhs string array
        /// Each item in lhs array must also be in rhs array.
        /// </summary>
        public override Object VisitStringArrayMemberOf(match_parserParser.StringArrayMemberOfContext context)
        {
            //# Tested
            String[] lhsValues = this.VisitOrDefault<String[]>(context.stringArray());
            StringPatternBase[] rhsValues = this.VisitOrDefault<StringPatternBase[]>(context.stringPatternArray());
            this.LTrace("MatchVisitorLocal.VisitStringArrayMemberOf", $"{lhsValues} {rhsValues}");

            if (lhsValues.Length == 0)
                return false;

            foreach (string lhsValue in lhsValues)
            {
                if (this.IsMemberOf(lhsValue, rhsValues) == false)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// See if lhs string is a member of rhs string array
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Object VisitStringValueMemberOf(match_parserParser.StringValueMemberOfContext context)
        {
            //# Tested
            String lhsValue = this.VisitOrDefault<String>(context.stringValue());
            StringPatternBase[] rhsValues = this.VisitOrDefault<StringPatternBase[]>(context.stringPatternArray());
            this.LTrace("MatchVisitorLocal.VisitStringValueMemberOf", $"{lhsValue} {rhsValues}");

            return this.IsMemberOf(lhsValue, rhsValues);
        }

        public override Object VisitStringValueMatch(match_parserParser.StringValueMatchContext context)
        {
            //# Tested
            String lhs = this.VisitOrDefault<String>(context.stringValue());
            StringPatternBase rhs = this.VisitOrDefault<StringPatternBase>(context.stringPattern());
            this.LTrace("MatchVisitorLocal.VisitStringValueMatch", $"{lhs} {rhs}");

            return rhs.IsMatch(lhs.ToUpper());
        }

        public override Object VisitGroupRule(match_parserParser.GroupRuleContext context)
        {
            //# Tested
            this.LTrace("MatchVisitorLocal.VisitGroupRule", "");
            return this.VisitOrDefault<Boolean>(context.boolRule());
        }

        public override Object VisitAndRule(match_parserParser.AndRuleContext context)
        {
            //# Tested
            this.LTrace("MatchVisitorLocal.VisitAndRule", "");
            foreach (match_parserParser.BoolRuleContext orRule in context.boolRule())
            {
                if (this.VisitOrDefault<bool>(orRule) == false)
                    return false;
            }
            return true;
        }

        public override Object VisitOrRule(match_parserParser.OrRuleContext context)
        {
            //# Tested
            this.LTrace("MatchVisitorLocal.VisitOrRule", "");
            foreach (match_parserParser.BoolRuleContext orRule in context.boolRule())
            {
                if (this.VisitOrDefault<bool>(orRule) == true)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Compose string value from string parts
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Object VisitStringValue(match_parserParser.StringValueContext context)
        {
            //# Tested
            this.LTrace("MatchVisitorLocal.VisitStringValue", "");

            StringBuilder sb = new StringBuilder();
            foreach (match_parserParser.StringSourceContext stringSourceContext in context.stringSource())
            {
                sb.Append(this.VisitOrDefault<String>(stringSourceContext));
            }
            return sb.ToString();
        }

        public override Object VisitQString(match_parserParser.QStringContext context)
        {
            //# Tested
            String retVal = this.UnQuote(context.QString().GetText());
            this.LTrace("MatchVisitorLocal.VisitQString", retVal);

            return retVal;
        }

        public override Object VisitInteger(match_parserParser.IntegerContext context)
        {
            //# Tested
            Int32 retVal = Int32.Parse(context.GetText());
            this.LTrace("MatchVisitorLocal.VisitInteger", $"{retVal}");
            return retVal;
        }

        public override Object VisitPathIndexedOpen(match_parserParser.PathIndexedOpenContext context)
        {
            //# Tested
            String path = this.VisitOrDefault<String>(context.path());
            Int32 index = this.VisitOrDefault<Int32>(context.integer());
            this.LTrace("MatchVisitorLocal.VisitPathIndexedOpen", $"{path} {index}");

            String[] parts = path.Split('.');
            if ((index < 0) | (index >= parts.Length))
                return "";

            StringBuilder sb = new StringBuilder();
            sb.Append(parts[index++]);
            while (index < parts.Length)
                sb.Append($".{parts[index++]}");
            return sb.ToString();
        }

        public override Object VisitPathIndexed(match_parserParser.PathIndexedContext context)
        {
            //# Tested
            String path = this.VisitOrDefault<String>(context.path());
            Int32 index = this.VisitOrDefault<Int32>(context.integer());
            this.LTrace("MatchVisitorLocal.VisitPathIndexed", $"{path} {index}");

            String[] parts = path.Split('.');
            if ((index < 0) | (index >= parts.Length))
                return "";
            return parts[index];
        }

        public override Object VisitSourcePath(match_parserParser.SourcePathContext context)
        {
            //# Tested
            this.LTrace("MatchVisitorLocal.VisitSourcePath", this.source.Path);
            return this.source.Path;
        }

        public override Object VisitSourceType(match_parserParser.SourceTypeContext context)
        {
            //# Tested
            this.LTrace("MatchVisitorLocal.VisitSourceType", "");
            return this.source.TypeNames();
        }

        public override Object VisitTargetPath(match_parserParser.TargetPathContext context)
        {
            //# Tested
            this.LTrace("MatchVisitorLocal.VisitTargetPath", this.target.Path);
            return this.target.Path;
        }

        public override Object VisitTargetType(match_parserParser.TargetTypeContext context)
        {
            //# Tested
            this.LTrace("MatchVisitorLocal.VisitTargetType", "");
            return this.target.TypeNames();
        }
    }
}
