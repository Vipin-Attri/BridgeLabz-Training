using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Instrumentation;

namespace fileHandlingIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Writing a simple text file
            //string path = "sample.txt";
            //File.WriteAllText(path, "Hello this is a sample file created to learn File Handling.");
            //Console.WriteLine("File created");


            // Reading a simple text file
            //string data = File.ReadAllText("sample.txt");
            //Console.WriteLine(data);


            // Writing multiple lines
            //string[] lines =
            //{
            //    "apple",
            //    "banana",
            //    "mango"
            //};
            //File.WriteAllLines("fruits.txt",lines);


            // Reading multiple lines
            //string[] lines = File.ReadAllLines("fruits.txt");
            //foreach(string line in lines)
            //{
            //    Console.WriteLine(line);
            //}


            // Writing CSV data
            //string[] csvData =
            //{
            //    "Id,Name,Age",
            //    "1,Vipin,21",
            //    "2,Vipul,23",
            //    "3,Atul,19"
            //};
            //File.WriteAllLines("students.csv", csvData);
            //Console.WriteLine("CSV File created");


            // Reading CSV Data
            //string[] data = File.ReadAllLines("students.csv");
            //foreach (string line in data)
            //{
            //    Console.WriteLine(line);
            //}


            // Spliting CSV Columns    line.Split(',');
            //string[] lines = File.ReadAllLines("students.csv");
            //foreach (string line in lines)
            //{
            //    string[] column = line.Split(',');
            //    foreach (string value in column)
            //    {
            //        Console.Write(value + " ");
            //    }
            //    Console.WriteLine();
            //}


            // Ignoring Header Row
            //string[] lines = File.ReadAllLines("students.csv");

            //for (int i = 1; i < lines.Length; i++)
            //{
            //    string[] columns = lines[i].Split(',');

            //    Console.Write($"ID: {columns[0]} ");
            //    Console.Write($"Name: {columns[1]} ");
            //    Console.WriteLine($"Age: {columns[2]}");
            //}


            // Using CSV with class for Reading the file
            //List<Student> students = new List<Student>();
            //string[] lines = File.ReadAllLines("students.csv");    // Reading file and input into string lines
            //for(int i = 1; i < lines.Length; i++)
            //{
            //    string[] data = lines[i].Split(',');  // splitting the line and input everything into the string 

            //    Student s = new Student();         // creating object

            //    s.id = int.Parse(data[0]);
            //    s.name = data[1];
            //    s.age = int.Parse(data[2]);

            //    students.Add(s);

            //}

            //foreach (Student s in students)
            //{
            //    Console.WriteLine($"id : {s.id}  name : {s.name}   age : {s.age}");
            //}


            //Using CSV with Class for Writing the File
            //List<Student> students = new List<Student>()
            //{
            //    new Student{id=1,name="John",age=21},
            //    new Student{id=2,name="Alice",age=19}
            //};
            //List<string> lines = new List<string>();
            //lines.Add("Id,Name,Age");
            //foreach(Student student in students)
            //{
            //    lines.Add($"{student.id},{student.name},{student.age}");
            //}
            //File.WriteAllLines("output.csv", lines);
            //Console.WriteLine("Csv File Written");




            //string[] lines1 = File.ReadAllLines("output.csv");    // Reading file and input into string lines
            //for (int i = 1; i < lines1.Length; i++)
            //{
            //    string[] data = lines1[i].Split(',');  // splitting the line and input everything into the string 

            //}

            //foreach (Student s in students)
            //{
            //    Console.WriteLine($"id : {s.id}  name : {s.name}   age : {s.age}");
            //}



            // Check if File exists
            //if (File.Exists("students.csv"))
            //{
            //    Console.WriteLine("File exists");
            //}
            //else
            //{
            //    Console.WriteLine("File Not Found");
            //}


            // Appending data
            //File.AppendAllText("students.csv", "/n4,Sam,23");


        }
    }
}
