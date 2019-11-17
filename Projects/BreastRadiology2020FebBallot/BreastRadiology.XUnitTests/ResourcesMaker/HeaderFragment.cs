using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String HeaderFragment()
        {
            SDefEditor sDef = this.CreateFragment("Header", "Resource", ResourceUrl);
            ContactDetail cd = new ContactDetail();
            cd.Telecom.Add(new ContactPoint
            {
                System = ContactPoint.ContactPointSystem.Url,
                Value = contactUrl
            });

            sDef.SDef.Contact.Add(cd);
            sDef.SDef.FhirVersion = FHIRVersion.N4_0_0;
            sDef.SDef.Date = this.date.ToString();
            sDef.SDef.Status = ProfileStatus;
            sDef.SDef.Publisher = "Hl7-Clinical Interoperability Council";
            sDef.SDef.Version = ProfileVersion;
            return sDef.SDef.Url;
        }
    }
}
