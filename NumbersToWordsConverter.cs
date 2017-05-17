using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    public class NumbersToWordsConverter
    {
        static Dictionary<int, string> units = new Dictionary<int, string>()
        {
            [0] = "",
            [1] = "one",
            [2] = "two",
            [3] = "three",
            [4] = "four",
            [5] = "five",
            [6] = "six",
            [7] = "seven",
            [8] = "eight",
            [9] = "nine",
            [10] = "ten",
            [11] = "eleven",
            [12] = "twelve",
            [13] = "thirteen",
            [14] = "fourteen",
            [15] = "fifteen",
            [16] = "sixteen",
            [17] = "seventeen",
            [18] = "eighteen",
            [19] = "nineteen",
            [20] = "twenty",
            [30] = "thirty",
            [40] = "forty",
            [50] = "fifty",
            [60] = "sixty",
            [70] = "seventy",
            [80] = "eighty",
            [90] = "ninety",
        };

        public static string Convert(int number)
        {
            int _number = 0;
            int digit = 0;
            string numberInWord = "";
            if (number < 1 || number > 1000)
            {
                return "Number out of range (1-1000)";
            }
            _number = number;
            digit = _number % 100;
            if (digit < 20)
            {
                numberInWord = units[digit];
                _number /= 100;
            }
            else
            {
                digit = _number % 10;
                numberInWord = units[digit];
                _number /= 10;
                digit = (_number % 10) * 10;
                numberInWord = units[digit] + "-" + numberInWord;
                _number /= 10;
            }
            digit = _number % 10;
            if (digit > 0)
            {
                numberInWord = units[digit] + " hundred " + (numberInWord != string.Empty ? "and " : "") + numberInWord;
                _number /= 10;
            }
            else
            {
                _number /= 10;
            }
            digit = _number % 10;
            if (digit > 0)
            {
                numberInWord = units[digit] + " thousand " + numberInWord;
                _number /= 10;
            }

            return numberInWord.TrimEnd(' ', '-');
        }
    }
}