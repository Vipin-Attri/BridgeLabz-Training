using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 0, 4, 0, 42,0,60,7,0,3,7,2,5,7,5,2 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] == 0)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
                foreach(int values in arr)
            {
                Console.WriteLine(values);
            }
        }
    }
}
