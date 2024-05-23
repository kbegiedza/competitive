public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var uniqueItems = 0;

        for (int left = 0, peeker = 0; left < nums.Length; ++left)
        {
            uniqueItems++;
            nums[left] = nums[peeker];

            do
            {
                peeker++;

                if (peeker >= nums.Length)
                {
                    return uniqueItems;
                }
            }
            while(nums[left] == nums[peeker]);
        }

        return uniqueItems;
    }
}