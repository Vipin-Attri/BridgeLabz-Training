using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsvHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a csv file using File

            //string[] lines =
            //{
            //    "ID,Name,Age",
            //    "1,Vipin,21",
            //    "2,Vipul,23",
            //    "3,Atul,19"
            //};
            //File.WriteAllLines("students.csv", lines);
            //Console.WriteLine("File Created");



            // Reading the file using CsvHelper (StreamReader)

            //using(StreamReader sr = new StreamReader("students.csv"))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}



            // Writing a file using CsvHelper (StreamWriter)
            //using (StreamWriter sw = new StreamWriter("sample.txt"))
            //{
            //    sw.WriteLine("hello");
            //    sw.WriteLine("My name is VAfitthetics.");
            //    sw.Close();
            //}

            // For appending 
            using (StreamWriter sw = new StreamWriter("sample.txt",true))
            {
                sw.WriteLine("Follow me on instagarm");
                sw.Close();
            }
        }
    }
}
