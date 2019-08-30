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
        void StartNameSpace(String ns);

        /// <summary>
        /// End namespace.
        /// </summary>
        void EndNameSpace();


        /// <summary>
        /// Start creating a class.
        /// </summary>
        void StartClass(String className, Type fhirType);

        /// <summary>
        /// End creating a class.
        /// </summary>
        void EndClass();


        /// <summary>
        /// Return text of generated code.
        /// </summary>
        String GetCode();
    }
}
