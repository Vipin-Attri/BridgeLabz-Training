using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    internal class Program
    {
        [Importantmethod]
        public void testmethod1()
        {
            Console.WriteLine("This is a test method 1.");
        }
        [Importantmethod("LOW")]
        public void testmethod2()
        {
            Console.WriteLine("This is a test method 2.");
        }
        static void Main(string[] args)
        {
            Program obj1=new Program();
            obj1.testmethod1();
            obj1.testmethod2();

            Console.WriteLine("\nMethods marked with Importantmethod:\n");

            Type t = typeof(Program);

            MethodInfo[] Methods = t.GetMethods();

            foreach(MethodInfo method in Methods)
            {
                ImportantmethodAttribute attr = method.GetCustomAttribute<ImportantmethodAttribute>();

                if (attr != null)
                {
                    Console.WriteLine("Method Name: " + method.Name);
                    Console.WriteLine("Importance level: " + attr.Level);
                    Console.WriteLine();
                }
            }

        }
    }
}
