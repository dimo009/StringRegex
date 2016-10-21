using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Homework_Valid_UserName_with_help
{
    class ValidUsernameII
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string pattern = @"(?<=[\s\/\\(\)]|^)([A-Za-z]\w{2,24})(?=[\s\/\\(\)]|$)";
            Regex rgx = new Regex(pattern);

            MatchCollection matches = Regex.Matches(input,pattern);
            List<string> valid = new List<string>();

            int maxSum = 0;
            int position = 0;
            for (int i = 0; i < matches.Count - 1; i++)
            {
                int currSum = matches[i].Length + matches[i + 1].Length;
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    position = i;
                }
            }

            Console.WriteLine(matches[position]);
            Console.WriteLine(matches[position + 1]);
        }
    }
}
