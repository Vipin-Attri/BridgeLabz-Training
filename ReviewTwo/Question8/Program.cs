using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number : ");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number % 3 == 0 )
            {
                Console.WriteLine("Pling");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Plang");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Plong");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
