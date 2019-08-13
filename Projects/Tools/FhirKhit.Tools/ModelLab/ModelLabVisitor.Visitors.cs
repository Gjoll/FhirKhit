using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools
{
    public partial class ModelLabVisitor<Section>
        where Section : ISection
    {
        protected abstract bool Visit_Stage1Start(Section model);

        protected abstract bool Visit_Stage1Complete(Section model);

        protected abstract bool Visit_Stage1_ComposeTarget(Section model);

        protected abstract bool Visit_Stage1_Profile(Section model);

        protected abstract bool Visit_Stage2_ModelSection(Section model);

        protected abstract bool Visit_Stage2_NumericProperty(Section model, ConfigData item);

        protected abstract bool Visit_Stage2_BooleanProperty(Section model, ConfigData item);

        protected abstract bool Visit_Stage2_DateTimeProperty(Section model, ConfigData item);

        protected abstract bool Visit_Stage2_StringProperty(Section model, ConfigData item);

        protected abstract bool Visit_Stage2_SelectElement(Section model, ConfigData item);

        protected abstract bool Visit_Stage2_CompositionReference(Section model, ConfigData item);
    }
}
