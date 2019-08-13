using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Antlr4.Runtime;

namespace FhirKhit.Tools.AntlrSupport
{
    /// <summary>
    /// This class implements an ANTLR error listener. When it herars an error, it will throw an exception and abort the 
    /// ANTLR processing.
    /// </summary>
    public class ThrowExceptionErrorListener : BaseErrorListener, IAntlrErrorListener<Int32>
    {
        /// <summary>
        /// 
        /// </summary>
        readonly String text;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="text"></param>
        public ThrowExceptionErrorListener(String text)
        {
            this.text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="line"></param>
        /// <param name="charPositionInLine"></param>
        void AppendInfo(StringBuilder sb, Int32 line, Int32 charPositionInLine)
        {
            line = line - 1; // line is one based....
            String[] lines = this.text.ToLines();
            if (line < 0)
                return;
            if (line >= lines.Length)
                return;
            if (line - 3 >= 0)
                sb.AppendLine(lines[line - 3]);
            if (line - 2 >= 0)
                sb.AppendLine(lines[line - 2]);
            if (line - 1 >= 0)
                sb.AppendLine(lines[line - 1]);
            if (charPositionInLine == 0)
                sb.AppendLine($"-->{lines[line]}");
            else if (charPositionInLine == lines[line].Length)
                sb.AppendLine($"{lines[line]}<--");
            else
                sb.AppendLine($"{lines[line].Substring(0, charPositionInLine)}-->{lines[line].Substring(charPositionInLine)}");
            if (line + 1 < lines.Length)
                sb.AppendLine(lines[line + 1]);
            if (line + 2 < lines.Length)
                sb.AppendLine(lines[line + 2]);
            if (line + 3 < lines.Length)
                sb.AppendLine(lines[line + 3]);
        }

        /// <summary>
        /// Called when a syntax error occurs.
        /// </summary>
        public override void SyntaxError(IRecognizer recognizer,
          IToken offendingSymbol,
          Int32 line,
          Int32 charPositionInLine,
          String msg,
          RecognitionException e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rule {e?.TargetSite?.Name} token {offendingSymbol?.Text}");
            sb.AppendLine($"Parse error: Line {line} Pos {charPositionInLine}. Msg {msg} ");
            this.AppendInfo(sb, line, charPositionInLine);
            throw new ArgumentException(sb.ToString());
        }

        /// <summary>
        /// Called when a syntax error occurs.
        /// </summary>
        public void SyntaxError(IRecognizer recognizer,
          Int32 offendingSymbol,
          Int32 line,
          Int32 charPositionInLine,
          String msg,
          RecognitionException e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rule {e?.TargetSite?.Name}");
            sb.AppendLine($"Parse error: Line {line} Pos {charPositionInLine}. Msg {msg} ");
            this.AppendInfo(sb, line, charPositionInLine);

            throw new ArgumentException(sb.ToString());
        }
    }
}
