using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //LinkedList Class
    internal class StudentList
    {
        private StudentNode head;

        //Add at the beginning
        public void AddAtBeginning(int rollNo,string name,int age,string grade)
        {
            StudentNode newNode=new StudentNode(rollNo,name,age,grade);
            newNode.next = head;
            head = newNode;

        }

        //Add at the last
        public void AddAtLast(int rollNo,string name,int age,string grade)
        {
            StudentNode NewNode = new StudentNode(rollNo, name, age, grade);
            if (head == null)
            {
                head = NewNode;
                return;
            }
            
                StudentNode temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = NewNode;
        }

        //Delete by Roll number
        public void Delete(int rollno)
        {
            if (head == null) return;

            if(head.RollNo == rollno)
            {
                head = head.next;
                return;
            }

            StudentNode temp = head;
            while(temp.next!=null && temp.next.RollNo != rollno)
            {
                temp = temp.next;
            }
            if (temp.next == null)
            {
                Console.WriteLine("Student Not Found");
                return;
            }
            temp.next = temp.next.next;
        }

        //Search by Roll number
        public void Search(int rollno)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if(temp.RollNo == rollno)
                {
                    Console.WriteLine($"Found Name: {temp.Name} Age: {temp.Age} Grade: {temp.Grade}");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student Not Found");
        }

        //Upgrade grade
        public void UpdateGrade(int rollno,string grade)
        {
            StudentNode temp = head;
            while(temp != null){
                if (temp.RollNo == rollno)
                {
                    temp.Grade = grade;
                    Console.WriteLine($"{temp.Name}'s grade has been updated to {temp.Grade}");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student not found.");
        }

        //Display All
        public void Display()
        {
            StudentNode temp = head;
            if (temp == null)
            {
                return;
            }
            while (temp != null)
            {
                Console.WriteLine($"Name: {temp.Name} Age: {temp.Age} Roll number:{temp.RollNo} Grade:{temp.Grade}");
                temp = temp.next;
            }
        }

    }
}
