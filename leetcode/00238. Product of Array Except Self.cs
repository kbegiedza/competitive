public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var left = new int[nums.Length];
        var right = new int[nums.Length];

        left[0] = 1;
        right[nums.Length-1] = 1;

        for (var i = 1; i < nums.Length; ++i)
        {
            left[i] = left[i-1] * nums[i-1];
        }

        for (var i = nums.Length-2; i >= 0; --i)
        {
            right[i] = right[i+1] * nums[i+1];
        }

        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; ++i)
        {
            result[i] = left[i] * right[i];
        }

        return result;
    }
}