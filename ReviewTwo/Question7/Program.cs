using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number1: ");
            int number1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Square of the sum of number's is: ");
            int sum = number1 + number2;
            Console.WriteLine(sum * sum);

            Console.Write("Square of the Difference of number's is: ");
            int difference = number1 - number2;
            Console.WriteLine(difference * difference);
        }
    }
}
