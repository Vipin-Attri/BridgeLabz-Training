using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class ProductOutOfStockException : Exception
    {
        public ProductOutOfStockException(string message) :base(message) { }
    }
}
