using System;
using Xunit;
using Testing;

namespace xUnitTesting
{
    public class TwoSumSolutionsTests
    {
        [Fact]
        public void TwoSum_TestCase1_ReturnsCorrectIndices()
        {
            //Arange 
            var twoSumSolution = new TwoSumSolution();
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            //Act
            var result = twoSumSolution.TwoSum(nums, target);

            //Assert
            Assert.Equal(0, result[0]);
            Assert.Equal(1, result[1]);
        }

        [Fact]
        public void TwoSum_TestCase2_ReturnsCorrectIndices()
        {
            // Arrange
            var twoSumSolution = new TwoSumSolution();
            var nums = new int[] { 3, 2, 4 };
            var target = 6;

            // Act
            var result = twoSumSolution.TwoSum(nums, target);

            // Assert
            Assert.Equal(1, result[0]);
            Assert.Equal(2, result[1]);
        }

        [Fact]
        public void TwoSum_TestCase3_ReturnsCorrectIndices()
        {
            // Arrange
            var twoSumSolution = new TwoSumSolution();
            var nums = new int[] { 3, 3 };
            var target = 6;

            // Act
            var result = twoSumSolution.TwoSum(nums, target);

            // Assert
            Assert.Equal(0, result[0]);
            Assert.Equal(1, result[1]);
        }
    }
}