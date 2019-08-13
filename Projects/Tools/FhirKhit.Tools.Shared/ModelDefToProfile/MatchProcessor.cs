using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using FhirKhit.Tools.AntlrSupport;
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
    /// Process Bmm Language data.
    /// </summary>
    public class MatchProcessor : IDisposable
    {
        /// <summary>
        /// If true, output debug info during parsing.
        /// </summary>
        public bool DebugFlag { get; set; } = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="domain"></param>
        public MatchProcessor()
        {
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// Create and initialize grammer. The grammar is returned and the caller can call any of the rules directly.
        /// </summary>
        /// <param name="text">ECL text</param>
        /// <returns>ANTLR parser</returns>
        public match_parserParser LoadGrammar(String text)
        {
            MemoryStream bmmStream = new MemoryStream();
            StreamWriter writer = new StreamWriter(bmmStream);
            writer.Write(text);
            writer.Flush();
            bmmStream.Position = 0;

            AntlrInputStream inputStream = new AntlrInputStream(bmmStream);

            match_parserLexer lexer = new match_parserLexer(inputStream);
            lexer.AddErrorListener(new ThrowExceptionErrorListener(text));

            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
            match_parserParser grammar = new match_parserParser(commonTokenStream);

            if (this.DebugFlag == true)
            {
                DebugParseListener parseListener = new DebugParseListener(grammar,
                  (s) => { Trace.WriteLine(s); });

                grammar.AddParseListener(parseListener);
            }

            grammar.RemoveErrorListeners();
            grammar.AddErrorListener(new ThrowExceptionErrorListener(text));
            return grammar;
        }

        /// <summary>
        /// </summary>
        public bool Compare(ElementDefinition source,
            ElementDefinition target, 
            String pattern)
        {
            match_parserParser grammar = this.LoadGrammar(pattern);
            IParseTree parseTree = grammar.match();

            MatchVisitorLocal visitor = new MatchVisitorLocal(source, target);
            Object o = visitor.Visit(parseTree);
            return (bool) o;
        }
    }
}
