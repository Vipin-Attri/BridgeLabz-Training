//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeAnnotationQuestions
//{
//    [AttributeUsage(AttributeTargets.Method)]
//    public class CustomAttribute : Attribute
//    {
//    }

//    public class Calculator
//    {
//        [CustomAttribute]
//        private void Multiply(int a, int b)
//        {
//            Console.WriteLine(a * b);
//        }
//    }

//    public class second
//    {
//        public static void Main()
//        {
//            Calculator calc = new Calculator();

//            Type type = typeof(Calculator);

//            MethodInfo[] methods =
//                type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

//            foreach (MethodInfo method in methods)
//            {
//                CustomAttribute attr =
//                    method.GetCustomAttribute<CustomAttribute>();

//                if (attr != null)
//                {
//                    method.Invoke(calc, new object[] { 4, 5 });
//                }
//            }
//        }
//    }
//}
