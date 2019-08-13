using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using FhirKhit.Tools.AntlrSupport;
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
    public class MapProcessor : IDisposable
    {
        /// <summary>
        /// If true, output debug info during parsing.
        /// </summary>
        public bool DebugFlag { get; set; } = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="domain"></param>
        public MapProcessor()
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
        public map_parserParser LoadGrammar(String text)
        {
            MemoryStream bmmStream = new MemoryStream();
            StreamWriter writer = new StreamWriter(bmmStream);
            writer.Write(text);
            writer.Flush();
            bmmStream.Position = 0;

            AntlrInputStream inputStream = new AntlrInputStream(bmmStream);

            map_parserLexer lexer = new map_parserLexer(inputStream);
            lexer.AddErrorListener(new ThrowExceptionErrorListener(text));

            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
            map_parserParser grammar = new map_parserParser(commonTokenStream);

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
        /// Execute map commands.
        /// </summary>
        public void ExecuteMapCommands(ModelDefProject modelDefCache,
            StructureDefinition sourceStructureDefinition,
            StructureDefinition targetStructureDefinition,
            StructureDefinition outputProfile,
            ElementDefinition sourceElement,
            ElementDefinition targetElement,
            ElementDefinitionMap  map,
            FhirDateTime date)
        {
            map_parserParser grammar = this.LoadGrammar(map.MapCommands);
            IParseTree parseTree = grammar.map();

            MapVisitorLocal visitor = new MapVisitorLocal(modelDefCache, 
                sourceStructureDefinition, 
                targetStructureDefinition, 
                outputProfile,
                sourceElement, 
                targetElement, 
                map,
                date);
            visitor.Visit(parseTree);
        }
    }
}
