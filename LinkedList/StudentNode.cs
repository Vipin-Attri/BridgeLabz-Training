using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //Node Class
    internal class StudentNode
    {
        
        public int RollNo;
        public string Name;
        public int Age;
        public string Grade;
        public StudentNode next;

       public StudentNode(int rollNo, string name, int age, string grade)
        {
            RollNo = rollNo;
            Name = name;
            Age = age;
            Grade = grade;
            next = null;
        }
       
    }
}
