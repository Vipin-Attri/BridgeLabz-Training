using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    
    internal class Program
    {
        [BugReport("Null value issue in login module")]
        [BugReport("Performance issue when loading dashboard")]
        public void hello()
        {
            Console.WriteLine("These are the bug reports");
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();

            obj1.hello();


            MethodInfo methodInfo =
            typeof(Program).GetMethod("hello");


            // Get all BugReport attributes

            object[] attributes =
                methodInfo.GetCustomAttributes(
                    typeof(BugReportAttribute),
                    false);

            // Print all bug reports

            foreach (BugReportAttribute bug in attributes)
            {
                Console.WriteLine($"- {bug.Description}");
            }


        }
    }
}
