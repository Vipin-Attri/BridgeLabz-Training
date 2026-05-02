using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"\d+"; // Matches one or more digits
            //string input = "The price is 100 dollars";

            //Match match = Regex.Match(input, pattern);
            //if (match.Success)
            //{
            //    Console.WriteLine("Match found: " + match.Value);
            //}


            //string pattern = @"\b\w+\b"; // Matches words in a string
            //string input = "Hello, World!";
            //MatchCollection matches = Regex.Matches(input, pattern);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine("Word: " + match.Value);
            //}



            //string pattern = @"[A-Z][a-z]+"; // Matches capitalized words
            //string input = "This is a Test String";

            //MatchCollection matches = Regex.Matches(input, pattern);
            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.Value);
            //}



            string pattern = @"\d{2,4}"; // Matches numbers with 2 to 4 digits
            string input = "Year: 2023, Code: 42, ID: 12345";

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
