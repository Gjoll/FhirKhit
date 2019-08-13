using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace FhirKhit.Tools.AntlrSupport
{
  /// <summary>
  /// ANTLR parse listener for debugging.
  /// </summary>
  public class DebugParseListener : IParseTreeListener
  {
    /// <summary>
    /// ANTLR lexer/parser.
    /// </summary>
    readonly IRecognizer parser;

    /// <summary>
    /// Delegate ot print message.
    /// </summary>
    /// <param name="message">Text of message</param>
    public delegate void MsgFcn(String message);

        /// <summary>
        /// Functio for printing message.
        /// </summary>
        readonly MsgFcn msgFcn;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="parser">ANTLR parser being executed</param>
    /// <param name="msgFcn">Message function to call</param>
    public DebugParseListener(Parser parser, MsgFcn msgFcn)
    {
      this.parser = parser;
      this.msgFcn = msgFcn;
    }

        /// <summary>
        /// Called each time a terminal is visited.
        /// </summary>
        /// <param name="node">node being visited</param>
        public void VisitTerminal(ITerminalNode node) => this.msgFcn($"Terminal {node.Symbol.Text}");

        /// <summary>
        /// Called each time an error node is visited.
        /// </summary>
        /// <param name="node">node being visited</param>
        public void VisitErrorNode(IErrorNode node) => this.msgFcn($"Error Node {node.Symbol.Text}");

        /// <summary>
        /// Called each time any rule is entered.
        /// </summary>
        /// <param name="ctx">Context of rule being entered</param>
        public void EnterEveryRule(ParserRuleContext ctx) => this.msgFcn("Enter: " + this.parser.RuleNames[ctx.RuleIndex]);

        /// <summary>
        /// Called each time any rule is exited.
        /// </summary>
        /// <param name="ctx">Context of rule being exited</param>
        public void ExitEveryRule(ParserRuleContext ctx) => this.msgFcn("Exit: " + this.parser.RuleNames[ctx.RuleIndex]);
    }
}
