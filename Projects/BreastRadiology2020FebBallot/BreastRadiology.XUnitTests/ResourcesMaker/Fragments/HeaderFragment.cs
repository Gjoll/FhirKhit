﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String HeaderFragment
        {
            get
            {
                if (findingHeaderFragment == null)
                    findingHeaderFragment = CreateHeaderFragment();
                return findingHeaderFragment;
            }
        }
        String findingHeaderFragment = null;
        String CreateHeaderFragment()
        {
            SDefEditor e = this.CreateFragment("HeaderFragment",
                "Resource",
                new string[] {"Common"},
                ResourceUrl);
            ContactDetail cd = new ContactDetail();
            cd.Telecom.Add(new ContactPoint
            {
                System = ContactPoint.ContactPointSystem.Url,
                Value = contactUrl
            });

            e.SDef.Contact.Add(cd);
            e.SDef.Date = this.date.ToString();
            e.SDef.Status = ProfileStatus;
            e.SDef.Publisher = "Hl7-Clinical Interoperability Council";
            e.SDef.Version = ProfileVersion;
            return e.SDef.Url;
        }
    }
}
