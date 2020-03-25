﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FhirKhit.Tools
{
    public abstract class ConverterBase : IConverter, IConversionInfo
    {
        public delegate bool StatusDelegate(String className, String method, String msg);

        public event StatusDelegate StatusErrors;
        public event StatusDelegate StatusWarnings;
        public event StatusDelegate StatusInfo;

        public IEnumerable<String> Errors => this.errors;
        List<String> errors = new List<String>();
        public bool HasErrors => this.errors.Count > 0;

        public IEnumerable<String> Warnings => this.warnings;
        List<String> warnings = new List<String>();
        public bool HasWarnings => this.warnings.Count > 0;

        public IEnumerable<String> Info => this.info;
        List<String> info = new List<String>();
        public bool HasInfo => this.info.Count > 0;

        public void ClearMessages()
        {
            this.info.Clear();
            this.warnings.Clear();
            this.errors.Clear();
        }

        public void ConversionError(String className, String method, IEnumerable<String> msgs)
        {
            if (className is null)
                throw new ArgumentNullException(nameof(className));
            if (msgs is null)
                throw new ArgumentNullException(nameof(msgs));
            foreach (String msg in msgs)
                ConversionError(className, method, msg);
        }

        public void ConversionError(String className, String method, String msg)
        {
            if (className is null)
                throw new ArgumentNullException(nameof(className));
            if (msg is null)
                throw new ArgumentNullException(nameof(msg));

            msg = msg.Trim();
            if (String.IsNullOrEmpty(msg))
                return;
            Log.Error($"{className}.{method}", msg);
            this.errors.Add(msg);
            if (StatusErrors != null)
                StatusErrors(className, method, msg);
        }

        public void ConversionWarn(String className, String method, IEnumerable<String> msgs)
        {
            if (className is null)
                throw new ArgumentNullException(nameof(className));
            if (msgs is null)
                throw new ArgumentNullException(nameof(msgs));

            foreach (String msg in msgs)
                ConversionWarn(className, method, msg);
        }


        public void ConversionWarn(String className, String method, String msg)
        {
            if (msg is null)
                throw new ArgumentNullException(nameof(msg));

            msg = msg.Trim();
            if (String.IsNullOrEmpty(msg))
                return;

            Log.Warn($"{className}.{method}", msg);
            this.warnings.Add(msg);
            if (StatusWarnings != null)
                StatusWarnings(className, method, msg);
        }

        public void ConversionInfo(String className, String method, IEnumerable<String> msgs)
        {
            if (msgs is null)
                throw new ArgumentNullException(nameof(msgs));


            foreach (String msg in msgs)
                ConversionInfo(className, method, msg);
        }

        public void ConversionInfo(String className, String method, String msg)
        {
            if (msg is null)
                throw new ArgumentNullException(nameof(msg));

            msg = msg.Trim();
            if (String.IsNullOrEmpty(msg))
                return;

            Log.Info($"{className}.{method}", msg);
            this.info.Add(msg);
            if (StatusInfo != null)
                StatusInfo(className, method, msg);
        }

        public bool FormatMessages(StringBuilder sb)
        {
            bool retVal = false;
            if (FormatErrorMessages(sb) == true)
                retVal = true;
            if (FormatWarnMessages(sb) == true)
                retVal = true;
            if (FormatInfoMessages(sb) == true)
                retVal = true;
            return retVal;
        }

        public bool FormatWarnMessages(StringBuilder sb)
        {
            if (sb is null)
                throw new ArgumentNullException(nameof(sb));

            if (this.Warnings.Any() == false)
                return false;
            sb.AppendLine($"**** Warnings *****");
            this.FormatMessages(sb, this.warnings);
            return true;
        }

        public bool FormatErrorMessages(StringBuilder sb)
        {
            if (sb is null)
                throw new ArgumentNullException(nameof(sb));

            if (this.Errors.Any() == false)
                return false;
            sb.AppendLine($"**** Errors *****");
            this.FormatMessages(sb, this.errors);
            return true;
        }

        public void FilterMessages(params String[] filters)
        {
            FilterErrorMessages(filters);
            FilterWarningMessages(filters);
            FilterInfoMessages(filters);
        }

        public void FilterWarningMessages(params String[] filters)
        {
            DoFilterMessages(this.warnings, filters);
        }

        public void FilterErrorMessages(params String[] filters)
        {
            DoFilterMessages(this.errors, filters);
        }

        public void FilterInfoMessages(params String[] filters)
        {
            DoFilterMessages(this.info, filters);
        }


        void DoFilterMessages(List<String> msgs, IEnumerable<String> filters)
        {
            bool failsFilter(String msg)
            {
                foreach (String filter in filters)
                    if (msg.Contains(filter))
                        return true;
                return false;
            }

            Int32 i = 0;
            while (i < msgs.Count)
            {
                if (failsFilter(msgs[i]))
                    msgs.RemoveAt(i);
                else
                    i += 1;
            }
        }

        public bool FormatInfoMessages(StringBuilder sb)
        {
            if (sb is null)
                throw new ArgumentNullException(nameof(sb));

            if (this.Info.Any() == false)
                return false;
            sb.AppendLine($"**** Informational *****");
            this.FormatMessages(sb, this.info);
            return true;
        }

        void FormatMessages(StringBuilder sb, List<String> msgs)
        {
            if (sb is null)
                throw new ArgumentNullException(nameof(sb));

            Int32 i = 1;
            foreach (String msg in msgs)
            {
                if (msg != null)
                {
                    String[] lines = msg.ToLines();
                    sb.AppendLine($"{i:D02}. {lines[0]}");
                    foreach (String line in lines.Skip(1))
                        sb.AppendLine($"  {line}");
                }
                i += 1;
            }
        }

    }
}
