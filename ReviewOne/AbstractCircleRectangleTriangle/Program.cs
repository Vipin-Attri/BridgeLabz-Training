using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircleRectangleTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.CalculateArea();

            Shape r = new Rectangle();
            r.CalculateArea();

            Shape t = new Triangle();
            t.CalculateArea();
        }
    }
}
