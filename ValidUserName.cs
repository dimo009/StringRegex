using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Homework_Valid_Username
{
    class ValidUserName
    {
        static void Main(string[] args)
        {
            char[] delimeters = new char[] { ' ', '/', ',', '\\' };
            string input = Console.ReadLine();
            int maxSum = int.MinValue;
            int sum = 0;
            //int leftMostCouple = 0;
            List<string> values = new List<string>();
            List<string> values1 = new List<string>();
            //string pattern = @"(,|\\|\s|\/)+(\D\w{2,25}_?)";
            //string pattern = @"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b";
            string pattern = @"(?<=[\s\/\\(\)]|^)([A-Za-z]\w{2,24})(?=[\s\/\\(\)]|$)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                values.Add(match.Value);
            }

            for (int i = 0; i < values.Count()-1; i++)
            {
                sum = values[i].Length + values[i + 1].Length;
                if (sum>maxSum)
                {
                    maxSum = sum;
                    values1.Add(values[i]);
                    values1.Add(values[i + 1]);
                   
                }
            }
            
               
                Console.WriteLine(values1[values.Count() - 2]);
            Console.WriteLine(values1[values.Count() - 1]);



        }
    }
}
