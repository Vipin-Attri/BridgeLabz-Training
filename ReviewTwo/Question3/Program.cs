using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        public static void checkproducts(int numberOfProducts)
        {
            if (numberOfProducts == 0)
            {
                throw new ProductOutOfStockException("No available products.");
                }
        }
        static void Main(string[] args)
        {
            try
            {
            int numberOfProducts=Convert.ToInt32(Console.ReadLine());
                checkproducts(numberOfProducts);
                Console.WriteLine("You can buy product from the store");
            }
            catch (ProductOutOfStockException) {
                Console.WriteLine("No available products.");
            }
        }
    }
}
