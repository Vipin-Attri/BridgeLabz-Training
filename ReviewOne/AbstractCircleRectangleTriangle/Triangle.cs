using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircleRectangleTriangle
{
    public class Triangle : Shape
    {
        double baseVal = 4;
        double height = 6;

        public override void CalculateArea()
        {
            Console.WriteLine((baseVal * height) / 2);
        }
    }
}
