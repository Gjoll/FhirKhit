using System;
using System.Diagnostics;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using FhirKhit.Tools.AntlrSupport;

namespace FhirKhit.Tools

{
    /// <summary>
    /// Process CIMPLMap Language data.
    /// </summary>
    public class CIMPLMapProcessor
    {
        /// <summary>
        /// If true, output debug info during parsing.
        /// </summary>
        public bool DebugFlag { get; set; } = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="domain"></param>
        public CIMPLMapProcessor()
        {
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
        /// <param name="text">CIMPLMap text</param>
        /// <returns>ANTLR parser</returns>
        public CIMPLMapParser LoadGrammar(String text)
        {
            MemoryStream CIMPLMapStream = new MemoryStream();
            StreamWriter writer = new StreamWriter(CIMPLMapStream);
            writer.Write(text);
            writer.Flush();
            CIMPLMapStream.Position = 0;

            AntlrInputStream inputStream = new AntlrInputStream(CIMPLMapStream);

            CIMPLMapLexer lexer = new CIMPLMapLexer(inputStream);
            lexer.AddErrorListener(new ThrowExceptionErrorListener(text));

            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
            CIMPLMapParser grammar = new CIMPLMapParser(commonTokenStream);

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
        /// Parse CIMPLMap text. Does not do post process link.
        /// </summary>
        /// <param name="CIMPLMapPath">CIMPLMap file to process</param>
        /// <returns>CIMPLMapFileBase of this file</returns>
        public CIMPLMap ParseCIMPLMap(String text)
        {
            try
            {
                CIMPLMapParser grammar = this.LoadGrammar(text);
                IParseTree parseTree = grammar.map();
                CIMPLMapVisitorLocal visitor = new CIMPLMapVisitorLocal();
                CIMPLMap retVal = (CIMPLMap) visitor.Visit(parseTree);
                return retVal;
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                throw new ApplicationException($"Error parsing CIMPLMap '{text}'", err);
            }
        }
    }
}
