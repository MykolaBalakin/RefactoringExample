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
            [0] = "zero",
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
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"{nameof(number)} should be non-negative");
            }

            if (NumberNames.ContainsKey(number))
            {
                return NumberNames[number];
            }

            if (number < 100)
            {
                var tens = number / 10 * 10;
                var ending = number % 10;

                return ending == 0
                    ? Convert(tens)
                    : $"{Convert(tens)}-{Convert(ending)}";
            }

            if (number < 1000)
            {
                var hundreds = number / 100;
                var ending = number % 100;

                return ending == 0
                    ? $"{Convert(hundreds)} hundred"
                    : $"{Convert(hundreds)} hundred and {Convert(ending)}";
            }

            throw new ArgumentOutOfRangeException(nameof(number), $"{nameof(number)} should be less than 1000");
        }
    }
}