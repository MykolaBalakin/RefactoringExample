using FluentAssertions;
using Xunit;

namespace Problem17
{
    public class Tests
    {
        [Theory]
        [InlineData(1, "one")]
        [InlineData(8, "eight")]
        [InlineData(10, "ten")]
        [InlineData(32, "thirty-two")]
        [InlineData(50, "fifty")]
        [InlineData(78, "seventy-eight")]
        [InlineData(100, "one hundred")]
        [InlineData(129, "one hundred and twenty-nine")]
        [InlineData(247, "two hundred and forty-seven")]
        [InlineData(461, "four hundred and sixty-one")]
        [InlineData(560, "five hundred and sixty")]
        [InlineData(999, "nine hundred and ninety-nine")]
        public void NumberToWord(int number, string expectedResult)
        {
            var actualResult = NumbersToWordsConverter.Convert(number);
            actualResult.Should().Be(expectedResult);
        }
    }
}