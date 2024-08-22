using LeetCodeProblems;

namespace LeetCode.Tests
{
    public class ProblemTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] {0,1})]
        [InlineData(new int[] { 3, 2, 4 },6,new int[] {1,2})]
        [InlineData(new int[] { 3, 3 },6,new int[] {0,1})]
        [InlineData(new int[] { 3, 4 },6,new int[] {})]
        public void Problem1Test(int[] nums,int target,int[] expected)
        {
            var result=Problem1.TwoSum(nums, target);
            Assert.Equal(expected, result);
        }
    }
}