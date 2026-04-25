using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonaciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int a = 0;
            int b = 1;
            while (n > 0)
            {
                Console.WriteLine(a);
                int temp = a + b;
                a = b;
                b = temp;
                n--;
            }

        }
    }
}
