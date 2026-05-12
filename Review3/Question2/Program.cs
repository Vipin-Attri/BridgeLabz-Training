using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines =
            {
                "Hi my name is Vipin",
                "Hello this my second review",
                "Thankyou for watching."
            };


            File.WriteAllLines("info.txt", lines);
            try
            {
                using (StreamReader sr = new StreamReader("info.txt"))
                {
                    string firstLine = sr.ReadLine();
                    Console.WriteLine("FirstLine : " + firstLine);
                    sr.Close();
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }
}
