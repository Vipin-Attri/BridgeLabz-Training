using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           NodeList list = new NodeList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Display();
            list.DisplayMiddle();


        }
    }
}
