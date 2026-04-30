using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 1, 2, 3 };
            double[] doublearray = { 9.0, 8.0, 7.0 };
            string[] stringarray = { "55", "44", "33" };
            DisplayInfo(intarray);
            DisplayInfo(doublearray);
            DisplayInfo(stringarray);
        }

        public static void DisplayInfo<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
