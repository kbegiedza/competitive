public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var leftItems = nums.Length;
        var right = nums.Length - 1;

        for (var left = 0; left <= right && left < nums.Length; ++left)
        {
            while (nums[left] == val)
            {
                leftItems--;

                if (left >= right)
                {
                    break;
                }

                nums[left] = nums[right];
                right--;
            }
        }

        return leftItems;
    }
}