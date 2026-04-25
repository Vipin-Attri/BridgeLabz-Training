using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircleRectangleTriangle
{
    public class Rectangle : Shape
    {
        double length = 4;
        double breadth = 5;

        public override void CalculateArea()
        {
            Console.WriteLine(length * breadth);
        }
    }
}
