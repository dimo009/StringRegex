using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hange_Numbers
{
    class LettersChangeNumber
    {
        static void Main(string[] args)
        {
            char[] delimeters = { ' ', '\t' };
            var input = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToList();

            string pattern1 = @"[A-Z]+\d+[a-z]"; // Upper case number lower case
            string pattern2 = @"[A-Z]+\d+[A-Z]"; //Upper case/number/upper case
            string pattern3 = @"[a-z]+\d+[A-Z]"; // Lower case/number/Upper case
            string pattern4 = @"[a-z]+\d+[a-z]";//only lower cases and number
            string pattern5 = @"[0-9]";           //only numbers
            double extractedNumber = 0;
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };
            char[] ALPHABET = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'G', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z' };
            double result = 0;

            Regex rgx1 = new Regex(pattern1);
            Regex rgx2 = new Regex(pattern2);
            Regex rgx3 = new Regex(pattern3);
            Regex rgx4 = new Regex(pattern4);
            Regex rgx5 = new Regex(pattern5);

            for (int i = 0; i < input.Count(); i++)
            {

                // upper case/number/lower case
                if (rgx1.IsMatch(input[i]))
                {
                    //creating char Array from the elements of input[i]
                    var elements = input[i].ToCharArray();
                    string b = string.Empty;



                    for (int k = 1; k <= elements.Length - 2; k++)
                    {
                        if (Char.IsDigit(elements[k]))
                        {
                            b += elements[k];
                        }
                    }
                    double firstLetterIndexValue = 1 + Array.IndexOf(ALPHABET, elements[0]);
                    extractedNumber = double.Parse(b);
                    double lastLetterNumericValue = 1 + Array.IndexOf(alphabet, elements[elements.Length - 1]);
                    result += extractedNumber / firstLetterIndexValue + lastLetterNumericValue;
                    continue;



                }

                //upper case/number/upper case
                if (rgx2.IsMatch(input[i]))
                {
                    //creating char Array from the elements of input[i]
                    var elements = input[i].ToCharArray();
                    //creating empty stringin order to store numeric values
                    string b = string.Empty;

                    //filling in the string b
                    for (int k = 1; k <= elements.Length - 2; k++)
                    {
                        if (Char.IsDigit(elements[k]))
                        {
                            b += elements[k];
                        }
                    }
                    //find the index of the first letter within one of the two char arrays(ALPHABET, alphabet);
                    double firstLetterIndexValue = 1 + Array.IndexOf(ALPHABET, elements[0]);
                    //int parse the string  in order to get the numeric value
                    extractedNumber = double.Parse(b);
                    //find the index of the last letter within one of the two char arrays(ALPHABET, alphabet);
                    double lastLetterNumericValue = 1 + Array.IndexOf(ALPHABET, elements[elements.Length - 1]);
                    result += extractedNumber / firstLetterIndexValue - lastLetterNumericValue;
                    continue;

                }

                //lower case/number/upper case
                if (rgx3.IsMatch(input[i]))
                {
                    //creating char Array from the elements of input[i]
                    var elements = input[i].ToCharArray();
                    string b = string.Empty;


                    for (int k = 1; k <= elements.Length - 2; k++)
                    {
                        if (Char.IsDigit(elements[k]))
                        {
                            b += elements[k];
                        }
                    }
                    double firstLetterIndexValue = 1 + Array.IndexOf(alphabet, elements[0]);
                    extractedNumber = double.Parse(b);
                    double lastLetterNumericValue = 1 + Array.IndexOf(ALPHABET, elements[elements.Length - 1]);
                    result += extractedNumber * firstLetterIndexValue - lastLetterNumericValue;
                    continue;

                }

                //lower case/number/lower case
                if (rgx4.IsMatch(input[i]))
                {
                    //creating char Array from the elements of input[i]
                    var elements = input[i].ToCharArray();

                    string b = string.Empty;


                    for (int k = 1; k <= elements.Length - 2; k++)
                    {
                        if (Char.IsDigit(elements[k]))
                        {
                            b += elements[k];
                        }
                    }
                    double firstLetterIndexValue = 1 + Array.IndexOf(alphabet, elements[0]);
                    extractedNumber = double.Parse(b);
                    double lastLetterNumericValue = 1 + Array.IndexOf(alphabet, elements[elements.Length - 1]);
                    result += extractedNumber * firstLetterIndexValue + lastLetterNumericValue;
                    continue;

                }

            }
            Console.WriteLine("{0:F2}", result);

        }
    }
}
