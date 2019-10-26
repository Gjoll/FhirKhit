using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace FhirKhit.Tools
{
    public class CodeBlockNested : CodeBlock
    {
        const String IndentOneLevel = "    ";

        public const Int32 CommentCol = 140;
        public delegate void CodeCallback(CodeBlockNested code);

        public IEnumerable<CodeBlockNested> AllNamedBlocks => this.NamedBlocks.Values;

        readonly Dictionary<String, CodeBlockNested> NamedBlocks = new Dictionary<String, CodeBlockNested>();
        Int32 macroInhibit = 0;

        /// <summary>
        /// Clear all content.
        /// </summary>
        public override void Clear()
        {
            this.NamedBlocks.Clear();
            this.Children.Clear();
        }

        /// <summary>
        /// Purge all children that are not in list.
        /// </summary>
        /// <param name="usedBlocks"></param>
        public void PurgeUnusedChildren(List<String> usedBlocks)
        {
            if (usedBlocks is null)
                throw new ArgumentNullException(nameof(usedBlocks));

            Int32 index = 0;
            while (index < this.Children.Count)
            {
                CodeBlock child = this.Children[index];
                if (usedBlocks.Contains(child.Name) == false)
                    this.Children.RemoveAt(index);
                else
                    index += 1;
            }
        }
        /// <summary>
        /// Return access to lines. This block must contains a single text block. otherwsie throw error.
        /// </summary>
        public List<String> Code
        {
            get
            {
                switch (this.Children.Count)
                {
                    case 0:
                        CodeBlockText temp = new CodeBlockText();
                        this.Children.Add(temp);
                        return temp.Code;

                    case 1:
                        if (this.Children[0] is CodeBlockText textBlock)
                            return textBlock.Code;
                        break;
                }

                throw new Exception("Invalid block access.");
            }
        }

        /// <summary>
        /// String that starts block ('//+...')
        /// </summary>
        public String StartLine
        {
            get { return this.startLine; }
            set
            {
                if (value is null)
                    throw new ArgumentNullException(nameof(value));

                this.startLine = value;
                this.baseMargin = value.Substring(0, value.IndexOf("//+"));
            }
        }
        String startLine;

        public String MarginString => this.baseMargin + this.indentMargin;
        public Int32 MarginLength => this.baseMargin.Length + this.indentMargin.Length;
        String baseMargin = "";
        String indentMargin = "";

        /// <summary>
        /// String that ends block ('//-...')
        /// </summary>
        public String EndLine { get; set; }

        /// <summary>
        /// Strings that make up code file.
        /// </summary>
        public List<CodeBlock> Children { get; } = new List<CodeBlock>();

        public CodeBlockNested(String name) : base(name)
        {
        }

        public CodeBlockNested IndentMarkerLines(Int32 indent)
        {
            StringBuilder sb = new StringBuilder();
            while (indent-- > 0)
                sb.Append(IndentOneLevel);
            this.StartLine = $"{sb.ToString()}{this.StartLine.Trim()}";
            this.EndLine = $"{sb.ToString()}{this.EndLine.Trim()}";
            return this;
        }

        public CodeBlockNested Indent()
        {
            this.indentMargin = this.indentMargin + IndentOneLevel;
            return this;
        }

        public CodeBlockNested Unindent()
        {
            this.indentMargin = this.indentMargin.Substring(0, this.indentMargin.Length - 4);
            return this;
        }

        /// <summary>
        /// Replace existing block with passed code.
        /// </summary>
        /// <param name="blockName"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public Boolean Replace(String blockName, String code) => this.Replace(blockName, code.ToLines());

        /// <summary>
        /// Replace existing block with passed code.
        /// </summary>
        /// <param name="blockName"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public Boolean Replace(String blockName, String[] code)
        {
            if (this.NamedBlocks.TryGetValue(blockName, out CodeBlockNested block) == false)
                return false;
            block.Children.Clear();
            block.Load(code);
            return true;
        }

        /// <summary>
        /// Find names block.
        /// </summary>
        /// <param name="blockName"></param>
        /// <returns></returns>
        public CodeBlockNested Find(String blockName, Boolean createFlag = false)
        {
            if (
                (this.NamedBlocks.TryGetValue(blockName, out CodeBlockNested block) == false) &&
                createFlag
            )
            {
                block = new CodeBlockNested(blockName)
                {
                    StartLine = $"{this.MarginString}//+ {blockName}",
                    EndLine = $"{this.MarginString}//- {blockName}"
                };
                this.NamedBlocks.Add(blockName, block);
                this.Children.Add(block);
            }

            return block;
        }

        /// <summary>
        /// Return array of all lines
        /// </summary>
        public override String[] Lines()
        {
            List<String> retVal = new List<String>();
            foreach (CodeBlock block in this.Children)
                retVal.AddRange(block.AllLines());
            return retVal.ToArray();
        }

        /// <summary>
        /// Return array of all lines
        /// </summary>
        public override String Text()
        {
            StringBuilder sb = new StringBuilder();
            foreach (String line in this.Lines())
                sb.AppendLine(line);
            return sb.ToString();
        }

        /// <summary>
        /// Return array of all lines
        /// </summary>
        public override String[] AllLines()
        {
            List<String> retVal = new List<String>();
            if ((string.IsNullOrWhiteSpace(this.Name) == false) && (this.Name[0] != '*'))
                retVal.Add(this.StartLine);
            foreach (CodeBlock block in this.Children)
                retVal.AddRange(block.AllLines());
            if ((string.IsNullOrWhiteSpace(this.Name) == false) && (this.Name[0] != '*'))
                retVal.Add(this.EndLine);
            return retVal.ToArray();
        }

        /// <summary>
        /// Return array of all lines
        /// </summary>
        public override String AllText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (String line in this.AllLines())
                sb.AppendLine(line);
            return sb.ToString();
        }

        /// <summary>
        /// Load code from 
        /// </summary>
        /// <param name="path"></param>
        public void Load(String[] lines)
        {
            if (lines is null)
                throw new ArgumentNullException(nameof(lines));

            this.Children.Clear();
            Int32 index = 0;
            this.DoLoad(lines, ref index);
        }

        /// <summary>
        /// Load code from 
        /// </summary>
        /// <param name="path"></param>
        void DoLoad(String[] lines, ref Int32 index)
        {
            CodeBlockText currentBlock = null;

            while (index < lines.Length)
            {
                String line = lines[index++];
                String s = line.Trim();

                if (s.StartsWith("//+"))
                {
                    // All blocks start with //+
                    s = s.Substring(3).Trim();
                    String blockName = s.Trim();

                    CodeBlockNested block = new CodeBlockNested(blockName);
                    block.StartLine = line;
                    this.Children.Add(block);
                    if (block.Name.Length > 0)
                        this.NamedBlocks.Add(block.Name, block);
                    block.DoLoad(lines, ref index);
                    currentBlock = null;
                }
                else if (s.StartsWith("//-"))
                {
                    // All blocks end  with //-
                    this.EndLine = line;
                    return;
                }
                else
                {
                    if (currentBlock == null)
                    {
                        currentBlock = new CodeBlockText();
                        this.Children.Add(currentBlock);
                    }

                    currentBlock.Code.Add($"{this.MarginString}{line}");
                }
            }
        }

        /// <summary>
        /// Add block of indicated name
        /// </summary>
        /// <param name="path"></param>
        public CodeBlockNested AppendBlock(String blockName = "")
        {
            CodeBlockNested block = new CodeBlockNested(blockName)
            {
                StartLine = $"{this.MarginString}//+ {blockName}",
                EndLine = $"{this.MarginString}//- {blockName}"
            };
            return AppendBlock(block);
        }

        public CodeBlockNested AppendBlock(CodeBlockNested block)
        {
            this.Children.Add(block);
            if (String.IsNullOrEmpty(block.Name) == false)
                this.NamedBlocks.Add(block.Name, block);
            return block;
        }

        /// <summary>
        /// Load code from 
        /// </summary>
        /// <param name="path"></param>
        public CodeBlockNested AppendRaw(String line)
        {
            CodeBlockText currentBlock = null;
            if (this.Children.Count > 0)
                currentBlock = this.Children[this.Children.Count - 1] as CodeBlockText;

            if (currentBlock == null)
            {
                currentBlock = new CodeBlockText();
                this.Children.Add(currentBlock);
            }

            String[] lines = line.ToLines();
            foreach (String l in lines)
                currentBlock.Code.Add(l);
            return this;
        }

        /// <summary>
        /// Load code from 
        /// </summary>
        /// <param name="path"></param>
        public CodeBlockNested AppendLine(String line)
        {
            this.AppendRaw(this.ProcessLine($"{this.MarginString}{line}"));
            return this;
        }

        /// <summary>
        /// Append comment lines. Split long lines. 
        /// </summary>
        public CodeBlockNested AppendComment(String[] lines)
        {
            if (lines == null)
                return this;

            this.macroInhibit += 1;
            foreach (String line in lines)
            {
                this.AppendLine($"// {line}");
            }
            this.macroInhibit -= 1;
            return this;
        }

        /// <summary>
        /// Append comment lines. Split long lines. 
        /// </summary>
        public CodeBlockNested AppendComment(String line)
        {
            const Int32 maxLength = 60;

            if (line == null)
                return this;

            this.macroInhibit += 1;
            while (line.Length > 0)
            {
                Int32 length = 0;
                StringBuilder sb = new StringBuilder();

                bool done = false;
                while ((length < line.Length) && (done == false))
                {
                    Char c = line[length++];
                    switch (c)
                    {
                        case '\r':
                            break;
                        case '\n':
                            done = true;
                            break;
                        case ' ':
                            if (length > maxLength)
                                done = true;
                            sb.Append(c);
                            break;
                        default:
                            sb.Append(c);
                            break;
                    }
                }
                this.AppendLine($"// {line.Substring(0, length)}");
                line = line.Substring(length);
            }

            this.macroInhibit -= 1;
            return this;
        }


        public CodeBlockNested SummaryOpen()
        {
            this.AppendLine("/// <summary>");
            return this;
        }

        public CodeBlockNested Summary(String line)
        {
            this.AppendLine($"/// {line}");
            return this;
        }

        public CodeBlockNested Summary(IEnumerable<String> lines)
        {
            this.AppendLines("/// ", lines);
            return this;
        }

        public CodeBlockNested SummaryClose()
        {
            this.AppendLine("/// </summary>");
            return this;
        }

        public CodeBlockNested SummaryLines(String lines)
        {
            String[] lineArr = lines.ToLines();
            foreach (String line in lineArr)
                this.AppendLine($"/// {line}");
            return this;
        }

        public CodeBlockNested AppendLines(String prefix, IEnumerable<String> lines)
        {
            foreach (String line in lines)
                this.AppendLine($"{prefix}{line}");
            return this;
        }

        public CodeBlockNested Example(params String[] text)
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));

            this.AppendLine("/// <example>");
            foreach (String line in text)
                this.AppendLine($"/// {line}");
            this.AppendLine("/// </example>");
            return this;
        }

        public CodeBlockNested OpenBrace([CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            this.AppendCode("{", filePath, lineNumber);
            this.Indent();
            return this;
        }

        public CodeBlockNested CloseBrace(String term = "",
            [CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            this.Unindent();
            this.AppendCode($"}}{term}", filePath, lineNumber);
            return this;
        }

        public CodeBlockNested InsertBlock(CodeBlockNested block,
            String blockName = "")
        {
            if (String.IsNullOrEmpty(blockName))
            {
                block.StartLine = "";
                block.EndLine = "";
            }
            else
            {
                block.StartLine = $"{this.MarginString}//+ {blockName}";
                block.EndLine = $"{this.MarginString}//- {blockName}";
            }
            this.AppendBlock(block);
            return this;
        }

        public CodeBlockNested DefineBlock(out CodeBlockNested block,
            String blockName = "")
        {
            block = this.AppendBlock(blockName);
            return this;
        }

        public CodeBlockNested BlankLine([CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            this.AppendCode(string.Empty, filePath, lineNumber);
            return this;
        }

        public CodeBlockNested If(bool value,
            CodeCallback ifCode,
            [CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            if (value)
            {
                if (CodeEditor.DebugFlag)
                    this.AppendCode($"//If: {filePath} {lineNumber}");
                ifCode(this);
            }
            return this;
        }

        public CodeBlockNested IfElse(bool value,
            CodeCallback ifCode,
            CodeCallback elseCode,
            [CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            if (value)
            {
                if (CodeEditor.DebugFlag)
                    this.AppendCode($"//If: {filePath} {lineNumber}");
                ifCode(this);
            }
            else
            {
                if (CodeEditor.DebugFlag)
                    this.AppendCode($"//Else: {filePath} {lineNumber}");
                elseCode(this);
            }
            return this;
        }

        public CodeBlockNested AppendCode(String codeLine,
            [CallerFilePath] String filePath = "",
            [CallerLineNumber] Int32 lineNumber = 0)
        {
            String line;
            String fileName = Path.GetFileName(filePath);
            if (CodeEditor.DebugFlag)
                line = this.ProcessLine($"{this.MarginString}{codeLine}%col:{CommentCol}%// {fileName}:{lineNumber}");
            else
                line = this.ProcessLine($"{this.MarginString}{codeLine}");

            this.AppendRaw(line);
            return this;
        }

        public CodeBlockNested AppendXml(XmlElement element, String commentChars = "//")
        {
            if (element is null)
                throw new ArgumentNullException(nameof(element));

            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\n",
                NewLineHandling = NewLineHandling.Replace,
                ConformanceLevel = ConformanceLevel.Auto
            };
            using (XmlWriter writer = XmlWriter.Create(sb, settings))
            {
                element.WriteContentTo(writer);
            }
            foreach (String line in sb.ToString().ToLines())
                this.AppendRaw($"{commentChars} {line}");

            return this;
        }

        void ProcessMacro(StringBuilder sb,
            String line,
            ref Int32 index)
        {
            String name = "";
            String value = "";
            Boolean valueFlag = false;
            while (true)
            {
                Char c = CodeBlockNested.GetChar(line, ref index);
                switch (c)
                {
                    case '\\':
                        c = CodeBlockNested.GetChar(line, ref index);
                        if (c != '%')
                            sb.Append('\\');
                        sb.Append(c);
                        break;

                    case '%':
                        switch (name.ToUpper().Trim())
                        {
                            case "COL":
                                if (int.TryParse(value, out Int32 col) == false)
                                    throw new Exception($"Invalid col macro value {value}");
                                while (sb.Length < col)
                                    sb.Append(" ");
                                return;

                            default:
                                throw new Exception($"Unknown $ macro name '{name}'");
                        }

                    case ':':
                        if (valueFlag == true)
                            throw new Exception("Invalid ':' flag in '%' string");
                        valueFlag = true;
                        break;

                    default:
                        if (valueFlag == false)
                            name += c;
                        else
                            value += c;
                        break;
                }
            }
        }

        static Char GetChar(String line, ref Int32 index)
        {
            if (line is null)
                throw new ArgumentNullException(nameof(line));

            if (index >= line.Length)
                throw new Exception("Unexpected end of string!");
            return line[index++];
        }

        String ProcessLine(String line)
        {
            StringBuilder sb = new StringBuilder();
            Int32 index = 0;
            Boolean quoteFlag = false;

            while (index < line.Length)
            {
                Char c = line[index++];
                switch (c)
                {
                    case '\"':
                        quoteFlag = !quoteFlag;
                        sb.Append(c);
                        break;

                    case '\\':
                        c = CodeBlockNested.GetChar(line, ref index);
                        if (c != '%')
                            sb.Append('\\');
                        sb.Append(c);
                        break;

                    case '%':
                        if ((this.macroInhibit > 0) || (quoteFlag == true))
                            sb.Append(c);
                        else
                            this.ProcessMacro(sb, line, ref index);
                        break;

                    default:
                        sb.Append(c);
                        break;

                }
            }

            return sb.ToString();
        }
    }
}
