using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.Homework_Extract_sentece_by_keyword
{
    class ExtractSenteceByKeyword
    {
        static void Main(string[] args)
        {

            string wordToMatch = Console.ReadLine();
            string text = Console.ReadLine();

            
            MatchCollection matches = IsSentence(text);

            foreach (Match sentence in matches)
            {
                string x = sentence.ToString();
                if (IsWordInSentence(x, wordToMatch))
                {
                    
                    Console.WriteLine(x.Trim());
                }
            }
        }

        private static bool IsWordInSentence(string sentence, string wordToMatch)
        {
            return Regex.Matches(sentence, string.Format(@"\b{0}\b", wordToMatch)).Count != 0;
        }

        private static MatchCollection IsSentence(string text)
        {
            //string pattern = @"([^.!?]+(?=[.!?])[.!?])"; // captures the last sign
            string pattern = @"([^.!?]+(?=[.!?]))"; // does not capture the last sign of a sentence(.,!,?)
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(text);
            return matches;
        }
    }
}

