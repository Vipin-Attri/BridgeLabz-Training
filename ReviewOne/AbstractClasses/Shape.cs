using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal abstract class Shape
    {
        public abstract void CalculateArea();
        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a Shape");
        }

    }

}
