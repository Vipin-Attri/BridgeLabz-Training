using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int.TryParse(Console.ReadLine() , out age);
            Console.WriteLine(age.ToString());
            Console.WriteLine(age);

        }
    }
}
