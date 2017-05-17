using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    public class NumbersToWordsConverter
    {
        static readonly IReadOnlyDictionary<int, string> NumberNames = new Dictionary<int, string>()
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
            if (number < 1 || number > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"{nameof(number)} should be in the range [1; 1000)");
            }

            int _number = 0;
            int digit = 0;
            string numberInWord = "";

            _number = number;
            digit = _number % 100;
            if (digit < 20)
            {
                numberInWord = NumberNames[digit];
                _number /= 100;
            }
            else
            {
                digit = _number % 10;
                numberInWord = NumberNames[digit];
                _number /= 10;
                digit = (_number % 10) * 10;
                numberInWord = NumberNames[digit] + "-" + numberInWord;
                _number /= 10;
            }
            digit = _number % 10;
            if (digit > 0)
            {
                numberInWord = NumberNames[digit] + " hundred " + (numberInWord != string.Empty ? "and " : "") + numberInWord;
                _number /= 10;
            }
            else
            {
                _number /= 10;
            }
            digit = _number % 10;
            if (digit > 0)
            {
                numberInWord = NumberNames[digit] + " thousand " + numberInWord;
                _number /= 10;
            }

            return numberInWord.TrimEnd(' ', '-');
        }
    }
}