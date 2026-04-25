using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircleRectangleTriangle
{
    public class Circle : Shape
    {
        double radius = 3;

        public override void CalculateArea()
        {
            Console.WriteLine(Math.PI * radius * radius);
        }
    }
}
