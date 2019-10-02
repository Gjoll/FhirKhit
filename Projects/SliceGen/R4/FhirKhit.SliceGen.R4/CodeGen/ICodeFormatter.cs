using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.R4
{
    /// <summary>
    /// Interface that each output code formatter (c#, java, etc) must implement.
    /// </summary>
    public interface ICodeFormatter
    {
        /// <summary>
        /// Start namespace.
        /// </summary>
        bool StartNameSpace(String ns);

        /// <summary>
        /// End namespace.
        /// </summary>
        bool EndNameSpace();


        /// <summary>
        /// Start creating a class.
        /// </summary>
        bool StartClass(String className, Type fhirType);

        /// <summary>
        /// End creating a class.
        /// </summary>
        bool EndClass();

        /// <summary>
        /// Create slices on indocated node.
        /// </summary>
        bool CreateSlice(ElementDefinitionNode elementNode);

        /// <summary>
        /// Return text of generated code.
        /// </summary>
        String GetCode();
    }
}
