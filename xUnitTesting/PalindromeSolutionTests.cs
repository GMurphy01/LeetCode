using System;
using Xunit;
using Testing;


namespace xUnitTesting
{
    public class PalindromeSolutionTests
    {
        [Fact]
        public void Palindrome_TestCase1_ReturnsCorrectBool()
        {
            //Arrange 
            var solution = new PalindromeSolution();
            var testNum1 = 121;

            //Act 
            var result = solution.IsPalindrome(testNum1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Palindrome_TestCase2_ReturnsCorrectBool()
        {
            //Arrange 
            var solution = new PalindromeSolution();
            var testNum1 = -121;

            //Act 
            var result = solution.IsPalindrome(testNum1);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Palindrome_TestCase3_ReturnsCorrectBool()
        {
            //Arrange 
            var solution = new PalindromeSolution();
            var testNum1 = 10;

            //Act 
            var result = solution.IsPalindrome(testNum1);

            //Assert
            Assert.False(result);
        }
    }
}
