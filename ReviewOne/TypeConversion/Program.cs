using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a;
            Console.WriteLine(b);

            double x = 10;
            int y = (int)x;
            Console.WriteLine(y);
        }
    }
}
