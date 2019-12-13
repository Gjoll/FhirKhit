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
using VTask = System.Threading.Tasks.Task;
using StringTask = System.Threading.Tasks.Task<string>;
namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        public async StringTask HeaderFragment()
        {
            if (findingHeaderFragment == null)
                await CreateHeaderFragment();
            return findingHeaderFragment;
        }
        String findingHeaderFragment = null;

        async VTask CreateHeaderFragment()
        {
            await VTask.Run(() =>
            {
                SDefEditor e = this.CreateFragment("HeaderFragment",
                    "Resource",
                    new string[] { "Common" },
                    ResourceUrl,
                    out findingHeaderFragment);
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

                e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Fragment($"Resource fragment used to by all resources to define common values such as Contact and Date.");
            });
        }
    }
}
