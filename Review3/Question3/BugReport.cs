using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    [AttributeUsage(AttributeTargets.Method , AllowMultiple = true)]
    internal class BugReportAttribute: Attribute
    {
        public string Description { get; }

        public BugReportAttribute(string description)
        {
            Description = description;
        }
    }
}
