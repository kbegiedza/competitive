public class Solution {
    public int PivotIndex(int[] nums) {
        var leftSums = new int[nums.Length];
        var rightSums = new int[nums.Length];

        leftSums[0] = 0;
        rightSums[nums.Length - 1] = 0;

        for (var i = 1; i < nums.Length; ++i)
        {
            leftSums[i] = leftSums[i-1] + nums[i-1];
        }

        for (var i = nums.Length - 2; i >= 0; --i)
        {
            rightSums[i] = rightSums[i+1] + nums[i+1];
        }

        for (var i = 0; i < nums.Length; ++i)
        {
            if (rightSums[i] == leftSums[i])
            {
                return i;
            }
        }

        return -1;
    }
}