using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practice p1 = new Practice();
            p1.hi();
            //p1.hello();   accessible same class only
            //p1.hola();    accessible same class and child class
            p1.nihao();
            p1.thankyou();
        }
    }
}
