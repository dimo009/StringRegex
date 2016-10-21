using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class ExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            char[] firstArr = input[0].ToCharArray();
            char[] secondArr = input[1].ToCharArray();

            var firstList = new List<char>();
            var secondList = new List<char>();

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (!firstList.Any(x => x == firstArr[i]))
                {
                    firstList.Add(firstArr[i]);
                }
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                if (!secondList.Any(x => x == secondArr[i]))
                {
                    secondList.Add(secondArr[i]);
                }
            }
            if (firstList.Count == secondList.Count)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
