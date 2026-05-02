using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        public static void ValidateAge(int age)
        {
            if (age < 0 || age > 150)
            {
                throw new CustomException("Invalid Age");
            }
        }
        static void Main(string[] args)
        {
                try
                {
                    int Age;
                    Age = Convert.ToInt32(Console.ReadLine());
                    ValidateAge(Age);
                Console.WriteLine("Nice age");

                }
                catch (CustomException)
                {
                    Console.WriteLine("Please enter a valid age");
                }
             

        }
    }
}
