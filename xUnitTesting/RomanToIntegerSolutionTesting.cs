using System;
using Xunit;
using Testing;

namespace xUnitTesting
{
    public class RomanToIntegerSolutionTesting
    {

        [Fact]
        public void RomanToInt_TestCase1_ReturnsCorrectValue()
        {
            //Arrange
            var solution = new RomanToIntegerSolution();
            var testRomanNumeral = "III";

            //Act
            var result = solution.RomanToInt(testRomanNumeral);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void RomanToInt_TestCase2_ReturnsCorrectValue()
        {
            //Arrange
            var solution = new RomanToIntegerSolution();
            var testRomanNumeral = "LVIII";

            //Act
            var result = solution.RomanToInt(testRomanNumeral);

            //Assert
            Assert.Equal(58, result);
        }

        [Fact]
        public void RomanToInt_TestCase3_ReturnsCorrectValue()
        {
            //Arrange
            var solution = new RomanToIntegerSolution();
            var testRomanNumeral = "MCMXCIV";

            //Act
            var result = solution.RomanToInt(testRomanNumeral);

            //Assert
            Assert.Equal(1994, result);
        }
    }
}
