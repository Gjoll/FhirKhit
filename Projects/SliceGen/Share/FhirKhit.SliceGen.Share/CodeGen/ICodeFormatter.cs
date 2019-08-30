using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.Share
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
        /// Create a property for the indicated element.
        /// </summary>
        /// <param name="sd"></param>
        /// <param name="original">This is the original element</param>
        /// <param name="profile">this is the profile element. It may be the same as the original, or it may be modified</param>
        void CreateProperty(ElementNode profileElement);


        /// <summary>
        /// Return text of generated code.
        /// </summary>
        String GetCode();
    }
}
