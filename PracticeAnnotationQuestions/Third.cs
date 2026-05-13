//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeAnnotationQuestions
//{
//    public class Person
//    {
//        private int age = 22;
//    }

//    public class Third
//    {
//        public static void Main()
//        {
//            Person p1 = new Person();

//            Type type = typeof(Person);

//            FieldInfo field =
//                type.GetField("age",
//                BindingFlags.NonPublic | BindingFlags.Instance);

//            field.SetValue(p1, 30);

//            Console.WriteLine(field.GetValue(p1));
//        }
//    }
//}
