using System;
using System.Diagnostics;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using FhirKhit.Tools.AntlrSupport;

namespace FhirKhit.Tools

{
    /// <summary>
    /// Process CIMPLCode Language data.
    /// </summary>
    public class CIMPLCodeProcessor : IDisposable
    {
        public delegate bool Macro(String name, out String value);
        public delegate bool Command(String name, String[] parameters, out String value);

        public Int32 ExpansionFailures = 0;

        Macro macro;
        Command command;

        /// <summary>
        /// If true, output debug info during parsing.
        /// </summary>
        bool DebugFlag { get; set; } = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="domain"></param>
        CIMPLCodeProcessor(Macro macro, Command command)
        {
            this.macro = macro;
            this.command = command;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// Method to load string grammar.
        /// </summary>
        /// <param name="text">CIMPLCode text</param>
        /// <returns>ANTLR parser</returns>
        CIMPLCodeParser LoadGrammar(String text)
        {
            MemoryStream CIMPLCodeStream = new MemoryStream();
            StreamWriter writer = new StreamWriter(CIMPLCodeStream);
            writer.Write(text);
            writer.Flush();
            CIMPLCodeStream.Position = 0;

            AntlrInputStream inputStream = new AntlrInputStream(CIMPLCodeStream);

            CIMPLCodeLexer lexer = new CIMPLCodeLexer(inputStream);
            lexer.AddErrorListener(new ThrowExceptionErrorListener(text));

            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
            CIMPLCodeParser grammar = new CIMPLCodeParser(commonTokenStream);

            if (this.DebugFlag == true)
            {
                DebugParseListener parseListener = new DebugParseListener(grammar,
                  (s) =>
                  {
                      Trace.WriteLine(s);
                  });
                grammar.AddParseListener(parseListener);
            }

            grammar.RemoveErrorListeners();
            grammar.AddErrorListener(new ThrowExceptionErrorListener(text));
            return grammar;
        }

        /// <summary>
        /// Parse CIMPLCode text. Does not do post process link.
        /// </summary>
        /// <param name="CIMPLCodePath">CIMPLCode file to process</param>
        /// <returns>CIMPLCodeFileBase of this file</returns>
        String Expand(String text)
        {
            try
            {
                CIMPLCodeParser grammar = this.LoadGrammar(text);
                IParseTree parseTree = grammar.code();
                CIMPLCodeVisitorLocal visitor = new CIMPLCodeVisitorLocal(this, macro, command);
                return (String) visitor.Visit(parseTree);
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                throw new ApplicationException($"Error parsing CIMPLCode '{text}'", err);
            }
        }

        public static String Expand(Macro macro, Command command, String text, bool debugFlag = false)
        {
            using (CIMPLCodeProcessor cp = new CIMPLCodeProcessor(macro, command))
            {
                cp.DebugFlag = debugFlag;
                return cp.Expand(text);
            }
        }
    }
}
