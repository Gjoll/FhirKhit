using System;
using System.Diagnostics;
using System.Text;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using FhirKhit.Tools.AntlrSupport;

namespace FhirKhit.Tools
{
    /// <summary>
    /// ANTLR Visitor class.
    /// </summary>
    public class CIMPLCodeVisitorLocal : CIMPLCodeBaseVisitor<Object>
    {
        CIMPLCodeProcessor processor;
        CIMPLCodeProcessor.Macro macro;
        CIMPLCodeProcessor.Command command;

        public CIMPLCodeVisitorLocal(CIMPLCodeProcessor processor,
                                    CIMPLCodeProcessor.Macro macro,
                                    CIMPLCodeProcessor.Command command)
        {
            this.processor = processor;
            this.macro = macro;
            this.command = command;
        }

        void TraceMsg(String m)
        {
            //Trace.WriteLine(m);
        }

        public override Object VisitCode([NotNull] CIMPLCodeParser.CodeContext context)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in context.items())
            {
                String s = (String)this.Visit(item);
                if (s != null)
                    sb.Append(s);
            }
            return sb.ToString();
        }


        public override Object VisitText([NotNull] CIMPLCodeParser.TextContext context)
        {
            return context.GetText();
        }

        bool DoCommand([NotNull] CIMPLCodeParser.CommandContext context, out String outValue)
        {
            outValue = null;
            if (this.command == null)
                return false;

            String name = context.TextChars().GetText();

            /*
             *If we cant expand any of the parameters, then dont execute command.
             * */
            Int32 expansionErrorCount = this.processor.ExpansionFailures;

            String[] parameters = this.VisitMultiple<String>(context.qString());
            if (expansionErrorCount != this.processor.ExpansionFailures)
                return false;

            if (this.command(name, parameters, out String value) == false)
                return false;

            this.Reprocess(value, out outValue);
            return true;
        }

        public override Object VisitCommand([NotNull] CIMPLCodeParser.CommandContext context)
        {
            if (DoCommand(context, out String outValue) == false)
            {
                this.processor.ExpansionFailures += 1;
                return context.GetText();
            }
            else
                return outValue;
        }

        public bool DoMacro([NotNull] CIMPLCodeParser.MacroContext context, out String outValue)
        {
            outValue = null;
            if (this.macro == null)
                return false;

            Debug.Assert(context.GetText().Contains("(") == false);

            String name = context.TextChars().GetText();
            if (this.macro(name, out String value) == false)
            {
                this.processor.ExpansionFailures += 1;
                return false;
            }

            this.Reprocess(value, out outValue);
            return true;
        }

        public override Object VisitQStringQuotes([NotNull] CIMPLCodeParser.QStringQuotesContext context)
        {
            String qString = (String)this.Visit(context.qString());
            return $"\"{qString}\"";
        }

        public override Object VisitQString([NotNull] CIMPLCodeParser.QStringContext context)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in context.qStringItem())
            {
                String s = this.VisitOrDefault<String>(item);
                if (s != null)
                    sb.Append(s);
            }
            return sb.ToString();
        }

        public override Object VisitMacro([NotNull] CIMPLCodeParser.MacroContext context)
        {
            if (DoMacro(context, out String outValue) == false)
                return context.GetText();
            else
                return outValue;
        }

        /// <summary>
        /// This is called when text is returned from an external delegate. We reprocess the text to make any recursive expansions,
        /// using the same delegates as originally entered.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        void Reprocess(String inValue, out String outValue)
        {
            outValue = null;
            if (inValue == null)
                return;

            outValue = CIMPLCodeProcessor.Expand(this.macro, this.command, inValue);
        }
    }
}
