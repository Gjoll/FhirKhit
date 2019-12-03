using FhirKhit.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Collections.Generic;
using BreastRadiology.XUnitTests;
using System.Drawing;

namespace BreastRadiology.XUnitTests
{
    [TestClass]
    public class BuildFrgments
    {

        [TestMethod]
        public void FormatCode()
        {
            String RemSpaceQuote(String s)
            {
                if (s.EndsWith(" \""))
                    s = s.Substring(0, s.Length - 2) + "\"";
                return s;
            }

            void FormatCode(String path)
            {
                Trace.WriteLine($"Processing {path}");
                List<String> lines = new List<String>(File.ReadAllLines(path));

                Int32 i = 0;
                while (i < lines.Count)
                {
                    String x = lines[i].Trim();
                    if (x.StartsWith("new ConceptDef("))
                    {
                        //Debug.Assert(x.Contains("new ConceptDef(\"Fatty\",") == false);

                        Trace.WriteLine($"Processing '{x}'");
                        i += 2;
                        String margin = lines[i].Substring(0, lines[i].IndexOf('"'));
                        lines.Insert(i++, $"{margin}new Definition()");
                        lines.Insert(i++, $"{margin}.CiteStart()");
                        while (true)
                        {
                            x = lines[i++].Trim();
                            if (x.EndsWith("+"))
                            {
                                //Trace.WriteLine($"Processing '+' '{x}'");
                                x = x.Substring(0, x.Length - 1).Trim();
                                x = RemSpaceQuote(x);
                                lines[i - 1] = $"{margin}    .Line({x})";
                            }
                            else if (x.EndsWith("\""))
                            {
                                //Trace.WriteLine($"Processing '\\\"' '{x}'");
                                String y = lines[i].Trim();
                                if ((y != ")") && (y != "),"))
                                    throw new NotImplementedException();
                                x = RemSpaceQuote(x);
                                lines[i - 1] = $"{margin}    .Line({x})";
                                lines.Insert(i++, $"{margin}.CiteEnd(BiRadCitation)");
                                i += 1;
                                break;
                            }
                            else if (x.EndsWith("),"))
                            {
                                //Trace.WriteLine($"Processing '),' '{x}'");
                                x = x.Substring(0, x.Length - 2).Trim();
                                x = RemSpaceQuote(x);
                                lines[i - 1] = $"{margin}    .Line({x})";
                                lines.Insert(i++, $"{margin}.CiteEnd(BiRadCitation)");
                                lines.Insert(i++, $"{margin}),");
                                break;
                            }
                            else if (x.EndsWith(")"))
                            {
                                //Trace.WriteLine($"Processing ')' '{x}'");
                                x = x.Substring(0, x.Length - 1).Trim();
                                x = RemSpaceQuote(x);
                                lines[i - 1] = $"{margin}    .Line({x})";
                                lines.Insert(i++, $"{margin}.CiteEnd(BiRadCitation)");
                                lines.Insert(i++, $"{margin})");
                                break;
                            }
                            else
                                throw new NotImplementedException();
                        }
                    }
                    else
                        i += 1;
                }
                File.WriteAllLines(path, lines);
            }

            void FormatDir(String path)
            {
                foreach (String f in Directory.GetFiles(path, "*.cs"))
                    FormatCode(f);
                foreach (String d in Directory.GetDirectories(path))
                    FormatDir(d);
            }

            String baseDir = DirHelper.FindParentDir("BreastRadiology2020FebBallot");
            FormatDir(Path.Combine(baseDir, "BreastRadiology.XUnitTests", "ResourcesMaker"));
        }
    }
}
