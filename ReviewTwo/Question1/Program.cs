using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        public static void Division(int number1,int number2)
        {
            if(number2 == 0)
            {
                throw new CustomException("Invalid input format");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                int number1 = 50;
                int number2 = 0;
                Division(number1, number2);
            }
            catch (CustomException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
        }
        
    }
}
