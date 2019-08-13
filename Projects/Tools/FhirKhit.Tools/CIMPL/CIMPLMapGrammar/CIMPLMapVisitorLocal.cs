using System;
using System.Diagnostics;
using Antlr4.Runtime.Misc;
using FhirKhit.Tools.AntlrSupport;
using static FhirKhit.Tools.CIMPLMapParser;

namespace FhirKhit.Tools
{
    /// <summary>
    /// ANTLR Visitor class.
    /// </summary>
    public class CIMPLMapVisitorLocal : CIMPLMapBaseVisitor<Object>
    {
        void TraceMsg(String m)
        {
            //Trace.WriteLine(m);
        }
        public override object VisitMap([NotNull] MapContext context)
        {
            return new CIMPLMap()
            {
                Target = this.VisitOrDefault<String>(context.target()),
                Arguments = this.VisitMultiple<CIMPLMap.Arg>(context.arg()),
                Commands  = this.VisitMultiple<CIMPLMap.Arg>(context.command())
            };
        }

        public override object VisitTarget([NotNull] TargetContext context)
        {
            String retVal = context?.GetText();
            TraceMsg($"Target '{retVal}'");
            return retVal;
        }

        public override object VisitArg([NotNull] ArgContext context)
        {
            CIMPLMap.Arg arg = new CIMPLMap.Arg();
            arg.Name = context.Name()?.GetText();
            arg.Values = this.VisitMultiple<String>(context.value());
            TraceMsg($"Arg '{arg.Name}'");
            return arg;
        }

        public override object VisitCommand([NotNull] CommandContext context)
        {
            CIMPLMap.Arg command = new CIMPLMap.Arg();
            command.Name = context.Name()?.GetText();
            command.Values = this.VisitMultiple<String>(context.value());
            TraceMsg($"Arg '{command.Name}'");
            return command;
        }

        public override object VisitValue([NotNull] ValueContext context)
        {
            String retVal = context.Name()?.GetText();
            if (String.IsNullOrEmpty(retVal) == true)
            {
                retVal = context.QString()?.GetText();
                retVal = retVal.Substring(1, retVal.Length - 2);
                TraceMsg($"Value'{retVal}'");
            }
            return retVal;
        }
    }
}
