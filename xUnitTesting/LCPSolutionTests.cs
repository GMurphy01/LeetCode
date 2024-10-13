using System;
using Xunit;
using Testing;

namespace xUnitTesting
{
    public class LCPSolutionTests
    {
        [Fact]
        public void LCPSolutionTests_TestCase1_CorrectPrefixReturned()
        {
            //Arrange
            var solution = new LongestCommonPrefixSolution();
            string[] testStringArr1 = ["flower", "flow", "flight"];

            //Act
            var result = solution.LongestCommonPrefix(testStringArr1);

            //Assert
            Assert.Equal("fl", result);
        }
    }
}
