using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    [AttributeUsage(AttributeTargets.Method)]

    internal class ImportantmethodAttribute : Attribute
    {
        public string Level { get; set; }
      public ImportantmethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }
}
