using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Mi nombre es Jose Taka y mi numero es +54-11-3063-2686";
            string pattern = @"\+\d{2}-\d{2}-\d{4}-\d{4}";
            Regex RegexTest = new Regex(pattern);

            MatchCollection MatchTest = RegexTest.Matches(phrase);

            if (MatchTest.Count > 0) Console.WriteLine("Number found");
            else Console.WriteLine("Number not found");
        }
    }
}
