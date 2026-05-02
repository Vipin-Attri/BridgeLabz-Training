using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[arr1.Length - 1];
            int position = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < position; i++)
            {
                arr2[i] = arr1[i];
            }
            for (int i = position + 1; i < arr1.Length; i++)
            {
                arr2[i-1] = arr1[i];
            }
            foreach (int values in arr2)
            {
                Console.WriteLine(values);
            }
        }
    }
}
