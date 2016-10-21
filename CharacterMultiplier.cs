using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HomeWork_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int sum = 0;
            string str1 = input[0];
            string str2 = input[1];

           

            str1.ToCharArray();
            str2.ToCharArray();

            int minLen = Math.Min(str1.Length, str2.Length);
            int maxLen = Math.Max(str1.Length, str2.Length);

            for (int i = 0; i < minLen; i++)
            {
                sum += (int)str1[i] * (int)str2[i];

            }

            if (minLen==maxLen)
            {
                Console.WriteLine(sum);
                return;
                
            }
            

            else if (maxLen != minLen)
            {
                if (str1.Length>str2.Length)
                {
                    for (int i = minLen+1;  i < maxLen; i++)
                    {
                        sum += str1[i];
                    }
                }
                if (str1.Length < str2.Length)
                {
                    for (int i = minLen; i < maxLen; i++)
                    {
                        sum += (int)str2[i];
                    }
                }
                
            }


            Console.WriteLine(sum);
        }
    }
}
