using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10_Extract_emails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string pattern = @"(?:^|\s)([a-zA-Z0-9][\-\._a-zA-Z0-9]*@[a-zA-Z\-]+(\.[a-z]+)+\b)";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matchCollection = regex.Matches(input);
            foreach (Match match in matchCollection)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
