using FhirKhit.Tools;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using Xunit;
using System.Collections.Generic;
using Antlr4.Runtime.Tree;
using System.Text;
#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.Tools.SharedTests
{
#if FHIR_R2
    public class FhirKhit_R2_MapParserTests
    {
        public FhirKhit_R2_MapParserTests()
        {
            ConsoleLog.SetLog(Log.LogLevel.InfoAndAbove);
            TraceLog.SetLog(Log.LogLevel.InfoAndAbove);
        }
#elif FHIR_R3
    public class FhirKhit_R3_MapParserTests
    {
        public FhirKhit_R3_MapParserTests()
        {
            ConsoleLog.SetLog(Log.LogLevel.InfoAndAbove);
            TraceLog.SetLog(Log.LogLevel.InfoAndAbove);
        }
#elif FHIR_R4
    public class FhirKhit_R4_MapParserTests
    {
        public FhirKhit_R4_MapParserTests()
        {
            ConsoleLog.SetLog(Log.LogLevel.InfoAndAbove);
            TraceLog.SetLog(Log.LogLevel.InfoAndAbove);
        }
#endif

        string DataDir => Path.Combine(DirHelper.FindParentDir("FhirKhit"), "Data");

        /// <summary>
        /// Create and initialize BMM parser
        /// </summary>
        /// <param name="domain">Domain for parser</param>
        /// <returns>Newly created parser</returns>
        MapProcessor CreateProcessor()
        {
            MapProcessor p = new MapProcessor();
            return p;
        }

        [Fact(DisplayName = "MapParser.FieldTerminologySource")]
        public void MapParserFieldTerminologySource()
        {
            ElementDefinitionMap map = new ElementDefinitionMap
            {
                FieldTerminologySource = "FTSource",
                FieldTerminologyId = "FTId"
            };

            using (MapProcessor p = this.CreateProcessor())
            {
                map_parserParser grammar = p.LoadGrammar("FieldTerminologySource");
                IParseTree parseTree = grammar.stringValue();
                MapVisitorLocal visitor = new MapVisitorLocal(null, null, null, null, null, null, map, null);
                String parsedData = (String)visitor.Visit(parseTree);
                Assert.True(parsedData == "FTSource");
            }

            using (MapProcessor p = this.CreateProcessor())
            {
                map_parserParser grammar = p.LoadGrammar("FieldTerminologyId");
                IParseTree parseTree = grammar.stringValue();
                MapVisitorLocal visitor = new MapVisitorLocal(null, null, null, null, null, null, map, null);
                String parsedData = (String)visitor.Visit(parseTree);
                Assert.True(parsedData == "FTId");
            }
        }

        /// <summary>
        /// Tests 'Coding'
        /// </summary>
        [Fact(DisplayName = "MapParser.ElementCoding")]
        public void MapParserElementCoding()
        {
            using (MapProcessor p = this.CreateProcessor())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("coding('System', 'Code')");
                map_parserParser grammar = p.LoadGrammar(sb.ToString());
                IParseTree parseTree = grammar.fhirElement();
                MapVisitorLocal visitor = new MapVisitorLocal(null, null, null, null, null, null, null, null);
                Coding parsedData = (Coding)visitor.Visit(parseTree);
                Assert.True(parsedData.System == "System");
                Assert.True(String.IsNullOrEmpty(parsedData.Version));
                Assert.True(parsedData.Code == "Code");
            }

            using (MapProcessor p = this.CreateProcessor())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("coding('System', 'Code', 'Version')");
                map_parserParser grammar = p.LoadGrammar(sb.ToString());
                IParseTree parseTree = grammar.fhirElement();
                MapVisitorLocal visitor = new MapVisitorLocal(null, null, null, null, null, null, null, null);
                Coding parsedData = (Coding)visitor.Visit(parseTree);
                Assert.True(parsedData.System == "System");
                Assert.True(parsedData.Version == "Version");
                Assert.True(parsedData.Code == "Code");
            }
        }


        /// <summary>
        /// Tests 'Coding'
        /// </summary>
        [Fact(DisplayName = "MapParser.Slice")]
        public void MapParserSlice()
        {
            ElementDefinitionMap map = new ElementDefinitionMap
            {
                FieldTerminologySource = "FTSource",
                FieldTerminologyId = "FTId"
            };

            ElementDefinition sourceElement = new ElementDefinition
            {
                Short = "SourceName"
            };

            ElementDefinition targetElement = new ElementDefinition
            {
                ElementId = "Observation.Component"
            };

            StructureDefinition outDef = new StructureDefinition
            {
                Differential = new StructureDefinition.DifferentialComponent()
            };

            StructureDefinition targetDef = new StructureDefinition
            {
                Differential = new StructureDefinition.DifferentialComponent()
            };

            targetDef.Differential.Element.Add(new ElementDefinition
            {
                ElementId = "Observation.Component",
                Path = "Observation.Component"
            });
            {
                MapVisitorLocal visitor = new MapVisitorLocal(null, null, targetDef, outDef, sourceElement, targetElement, map, null);

                StringBuilder sb = new StringBuilder();
                sb.Append("slice()");

                using (MapProcessor p = this.CreateProcessor())
                {
                    map_parserParser grammar = p.LoadGrammar(sb.ToString());
                    IParseTree parseTree = grammar.mapNewElement();
                    ElementDefinition parsedData = (ElementDefinition)visitor.Visit(parseTree);
                    Assert.True(parsedData.ElementId == "Observation.Component:SourceName");
                }
            }

            {
                MapVisitorLocal visitor = new MapVisitorLocal(null, null, targetDef, outDef, sourceElement, targetElement, map, null);

                StringBuilder sb = new StringBuilder();
                sb.Append("slice('code', coding('Snomed', '100000'))");

                using (MapProcessor p = this.CreateProcessor())
                {
                    map_parserParser grammar = p.LoadGrammar(sb.ToString());
                    IParseTree parseTree = grammar.mapNewElement();
                    ElementDefinition parsedData = (ElementDefinition)visitor.Visit(parseTree);
                    Assert.True(parsedData.ElementId == "Observation.Component:SourceName");
                }
            }
        }
    }
}
