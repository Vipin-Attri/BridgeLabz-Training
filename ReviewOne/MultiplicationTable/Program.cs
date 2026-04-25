using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "*" + i + "=" + n * i);
            }
        }
    }
}
