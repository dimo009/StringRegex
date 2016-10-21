using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Homework_Convert_from_10_base_to_N_base
{
    class From10ToNbase
    {
        static void Main(string[] args)
        {

             

            
            List<BigInteger> numbers = new List<BigInteger>();
           
            numbers = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();
            int n = (int)numbers[0];
            BigInteger number = numbers[1];
            BigInteger remainder;
            string result = null;

            if (n>=2&&n<=10)
            {
                while (number>0)
                {
                    remainder = number % n;
                    number /= n;

                    result = remainder.ToString() + result;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
