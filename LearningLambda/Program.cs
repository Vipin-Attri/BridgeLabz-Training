using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLambda
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(1, 2);
            Console.WriteLine(result);
            Action<string> print = msg => Console.WriteLine(msg);
            print("Teen Paanch");
        }
    }
}
