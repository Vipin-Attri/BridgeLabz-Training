using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size:");
            int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("Enter the index:");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arr[value]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRange");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");

            }
        }
    }
}
