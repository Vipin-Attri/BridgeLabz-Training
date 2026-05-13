using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAnnotationQuestions
{
    public class Person
    {
        public int age = 21;

        public Person()
        {
        }

        public void Display()
        {
        }
    }

    public class Fifth
    {
        public static void Main()
        {
            Type type = typeof(Person);

            MethodInfo[] methods = type.GetMethods();
            FieldInfo[] fields = type.GetFields();
            ConstructorInfo[] constructors = type.GetConstructors();

            Console.WriteLine("Methods:");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("\nFields:");
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("\nConstructors:");
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
            }
        }
    }
}
