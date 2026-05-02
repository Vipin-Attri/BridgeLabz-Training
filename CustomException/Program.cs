using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    internal class Program
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Invalid age");
                }
        }
        static void Main(string[] args)
        {
            try
            {
                int age;
                age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
                Console.WriteLine("Age is valid");
            }
            catch (InvalidAgeException) {
                Console.WriteLine("Age must be 18 or above");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }

        }
    }
}
