using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace FhirKhit.Tools
{
    /// <summary>
    /// Class to edit code.
    /// </summary>
    public class CodeEditor
    {
        public static bool DebugFlag { get; set; } = true;

        public String BlockStart { get; set; } = "//+";
        public String BlockStartTerm { get; set; } = "";
        public String BlockEnd { get; set; } = "//-";
        public String BlockEndTerm { get; set; } = "";

        public bool IgnoreMacrosInQuotedStrings {get; set; }  = true;

        /// <summary>
        /// Strings that make up code file.
        /// </summary>
        public CodeBlockNested Blocks { get; }

        /// <summary>
        /// Value can be a
        /// - a string
        /// - a list of strings
        /// - a list of string lists.
        /// </summary>
        Dictionary<String, Object> userMacros = new Dictionary<string, Object>();

        public String SavePath { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public CodeEditor()
        {
             this.Blocks = new CodeBlockNested(this, "");
        }

        /// <summary>
        /// Load code from 
        /// </summary>
        /// <param name="path"></param>
        public void Load(String path)
        {
            if (File.Exists(path) == false)
                throw new Exception($"File '{path}' not found");
            String[] lines = File.ReadAllLines(path);
            this.Load(lines, false);
            this.SavePath = path;
        }

        /// <summary>
        /// SaveXml code
        /// </summary>
        /// <param name="path"></param>
        public String Save() => this.Save(this.SavePath);

        /// <summary>
        /// SaveXml code
        /// </summary>
        /// <param name="path"></param>
        public String Save(String path)
        {
            this.SavePath = path;
            String newCode = this.ToString();
            if (File.Exists(path) == true)
            {
                String oldCode = File.ReadAllText(path);
                if (string.Compare(newCode, oldCode, StringComparison.InvariantCulture) == 0)
                    return this.SavePath;
            }
            File.WriteAllText(path, newCode);
            return this.SavePath;
        }

        public override string ToString()
        {
            return this.Blocks.AllText();
        }

        /// <summary>
        /// Load code from 
        /// </summary>
        /// <param name="path"></param>
        public void Load(String[] lines, bool addMargin = true) => this.Blocks.Load(lines, addMargin);

        public bool TryGetUserMacro(String name, out Object value)
        {
            return this.userMacros.TryGetValue(name, out value);
        }

        public bool TryAddUserMacro(String name, Object value)
        {
            if (String.IsNullOrEmpty(name))
                throw new Exception($"Invalid null or empty user macro name");
            if (Char.IsUpper(name[0]) == false)
                throw new Exception($"Invalid user macro name {name}. All user macros must start with upper case letter");
            return this.userMacros.TryAdd(name, value);
        }
    }
}