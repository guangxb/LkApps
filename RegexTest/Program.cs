using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {

            // Define a regular expression for repeated words.
            Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            //Regex rx = new Regex(@"^[\u4e00-\u9fa5]+$");
            // Define a test string.
            string text = "The the quick brown fox  fox jumped over the lazy dog dog.";
            // Find matches.
            MatchCollection matches = rx.Matches(text);
            Console.WriteLine(rx.IsMatch(text));
            Console.ReadKey();

            // Report the number of matches found.
            Console.WriteLine("{0} matches found in:\n   {1}", matches.Count, text);

            // Report on each match.
            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("'{0}' repeated at positions {1} and {2}",
                                          groups["word"].Value,
                                          groups[0].Index,
                                          groups[1].Index);
            }

            Console.ReadKey();
        }
    }
}
