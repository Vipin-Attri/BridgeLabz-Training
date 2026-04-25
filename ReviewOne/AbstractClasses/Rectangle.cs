using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Rectangle: Shape
    {
        int length = 3, breadth = 2;
        public override void CalculateArea()
        {
            Console.WriteLine(length * breadth);
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("It is a rectangle");
        }
    }
}
