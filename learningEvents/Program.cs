using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process p=new Process();
            p.OnCompleted += Task1;
            p.OnCompleted += Task2;
            p.Start();


        }
        public static void Task1()
        {
            Console.WriteLine("Task1 copleted");
        }
        public static void Task2()
        {
            Console.WriteLine("Task1 copleted");
        }
    }
}
