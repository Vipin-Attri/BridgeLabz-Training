using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList list = new StudentList();

            
            list.AddAtBeginning(2, "Rahul", 21, "B");
            list.AddAtLast(1, "Vipin", 20, "A");
            list.AddAtLast(3, "John", 20, "D");



            list.Display();

            Console.WriteLine("\nSearch Roll 2:");
            list.Search(2);

            Console.WriteLine("\nUpdate Grade:");
            list.UpdateGrade(3, "A+");

            Console.WriteLine("\nAfter Update:");
            list.Display();

            Console.WriteLine("\nDelete Roll 1:");
            list.Delete(1);

            Console.WriteLine("\nFinal List:");
            list.Display();
        }
    }
}
